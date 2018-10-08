using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace ArduinoOutput
{
    public class JoystickOutput
    {
        private SerialPort _serialPort;

        public int BaudRate { get { return _serialPort.BaudRate; } set { _serialPort.BaudRate = value; } }
        public string PortName { get { return _serialPort.PortName; } set { _serialPort.PortName = value; } }

        public event EventHandler<DirectionEventArgs> DirectionChanged;
        public event EventHandler<ButtonEventArgs<Button>> ButtonPressed;

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
            string serialInput;
            while (true)
            {
                serialInput = _serialPort.ReadExisting();
                if (serialInput.Contains("Button:"))
                {
                    Task.Run(() => GetButton(serialInput));
                }
                if (serialInput.Contains("Direction:"))
                {
                    Task.Run(() => GetDirection(serialInput));
                }
                //switch (serialInput)
                //{
                //    case "Button:":
                //        await Task.Run(() => GetButton(serialInput));
                //        break;
                //    case "Direction:":
                //        await Task.Run(() => GetDirection(serialInput));
                //        break;
                //    default:
                //        break;
                //}
                Thread.Sleep(100);
            }
        }

        private void GetDirection(string a)
        {
            if (a.Contains("Right"))
                OnDirectionChanged(Direction.Right);
            if (a.Contains("Left"))
                OnDirectionChanged(Direction.Left);
            if (a.Contains("Up"))
                OnDirectionChanged(Direction.Up);
            if (a.Contains("Down"))
                OnDirectionChanged(Direction.Down);
        }
        private void GetButton(string a)
        {
            if (a.Contains("D5"))
                OnButtonPressed(Button.D5);
            if (a.Contains("D4"))
                OnButtonPressed(Button.D4);
            if (a.Contains("D3"))
                OnButtonPressed(Button.D3);
            if (a.Contains("D6"))
                OnButtonPressed(Button.D6);
        }

        protected virtual void OnDirectionChanged(Direction dir)
        {
            DirectionEventArgs de = new DirectionEventArgs(dir);
            DirectionChanged?.Invoke(this, de);
        }
        protected virtual void OnButtonPressed(Button butt)
        {
            ButtonEventArgs<Button> bea = new ButtonEventArgs<Button>(butt);
            ButtonPressed?.Invoke(this, bea);
        }
    }
}
