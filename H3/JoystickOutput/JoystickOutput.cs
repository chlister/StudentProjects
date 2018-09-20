using System;
using System.IO;
using System.IO.
    

namespace ArduinoOutput
{
    public class JoystickOutput
    {
        private SerialPort _serialPort;

        public int BaudRate { get { return _serialPort.BaudRate; } set { _serialPort.BaudRate = value; } }
        public string PortName { get { return _serialPort.PortName; } set { _serialPort.PortName = value; } }

        public event EventHandler<DirectionEvent> DirectionChanged;

        public JoystickOutput()
        {
            _serialPort = new SerialPort();
            PortName = "COM4";
            BaudRate = 9600;
            _serialPort.Open();
            Task.Run(() => ReadInput());
        }

        private void ReadInput()
        {
            string a;
            while (true)
            {
                a = _serialPort.ReadExisting();
                if (a.Contains("Button:"))
                {
                    Task.Run(() => GetButton(a) );
                }
                if (a.Contains("Direction:"))
                {
                    Task.Run(() => GetDirection(a));
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Returns the direction value as a string
        /// </summary>
        /// <returns></returns>
        private void GetDirection(string a)
        {
            if (a.Contains("Right"))
            {
                Debug.WriteLine("Direction: Right");
                OnDirectionChanged("RIGHT");
            }
            if (a.Contains("Left"))
            {
                Debug.WriteLine("Direction: Left");

                OnDirectionChanged("LEFT");
            }
            if (a.Contains("Up"))
            {
                Debug.WriteLine("Direction: Up");

                OnDirectionChanged("UP");
            }
            if (a.Contains("Down"))
            {
                Debug.WriteLine("Direction: Down");

                OnDirectionChanged("DOWN");
            }
            //Thread.Sleep(200);
        }

        private void GetButton(string a)
        {
            if (a.Contains("D5"))
            {
                Debug.WriteLine("Button: RED");
                OnDirectionChanged("RED");
            }
            if (a.Contains("D4"))
            {
                Debug.WriteLine("Button: BLUE");

                OnDirectionChanged("BLUE");
            }
            if (a.Contains("D3"))
            {
                Debug.WriteLine("Button: YELLOW");

                OnDirectionChanged("YELLOW");
            }
            if (a.Contains("D6"))
            {
                Debug.WriteLine("Button: WHITE");

                OnDirectionChanged("WHITE");
            }
            //Thread.Sleep(200);
        }

        protected virtual void OnDirectionChanged(string dir)
        {
            DirectionEvent de = new DirectionEvent();
            de.Direction = dir;
            DirectionChanged?.Invoke(this, de);
        }
    }
}
