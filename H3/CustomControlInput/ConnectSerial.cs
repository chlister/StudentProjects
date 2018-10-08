using System;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace CustomControlInput
{
    public class ConnectSerial
    {
        private readonly SerialPort _serialPort;
        public int BaudRate
        {
            get { return _serialPort.BaudRate; }
            private set { _serialPort.BaudRate = value; }
        }
        public string PortName
        {
            get { return _serialPort.PortName; }
            private set { _serialPort.PortName = value; }
        }
        public bool IsOpen
        {
            get { return _serialPort.IsOpen; }
        }
        public event EventHandler<FryState> FryStateChanged;
        public event EventHandler<PotState> PotStateChanged;
        public event EventHandler<DirectionEventArgs> DirectionChanged;
        public event EventHandler<ButtonEventArgs<CuttingButtons>> CuttingButtonPressed;
        public event EventHandler<ButtonEventArgs<FryButtons>> FryButtonPressed;
        public event EventHandler<ButtonEventArgs<AssemblerButtons>> AssemblerButtonPressed;
        public event EventHandler<ButtonEventArgs<PotButtons>> PotButtonPressed;

        public ConnectSerial(string portName, int baudRate)
        {
            PortName = portName;
            BaudRate = baudRate;
        }

        private void ReadInput()
        {
            string serialInput;
            while (true)
            {
                serialInput = _serialPort.ReadExisting();
                if (serialInput.Contains("C:"))
                {
                    Task.Run(() => GetCuttingInput(serialInput));
                }
                if (serialInput.Contains("J"))
                {
                    Task.Run(() => GetAssemblerInput(serialInput));
                }
                if (serialInput.Contains("F:"))
                {
                    Task.Run(() => GetFryInput(serialInput));
                }
                if (serialInput.Contains("P:"))
                {
                    Task.Run(() => GetPanInput(serialInput));
                }

                //Thread.Sleep(100);
            }
        }

        private void GetPanInput(string serialInput)
        {
            throw new NotImplementedException();
        }

        private void GetFryInput(string serialInput)
        {
            throw new NotImplementedException();
        }

        private void GetAssemblerInput(string serialInput)
        {
            throw new NotImplementedException();
        }

        private void GetCuttingInput(string serialInput)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            try
            {
                if (!IsOpen)
                {
                    _serialPort.Open();
                    Task.Run(() => ReadInput());
                }
            }
            catch (UnauthorizedAccessException)
            {
                Debug.WriteLine("Access denied to the port, or another process is using it");
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.WriteLine("One or more properties of this instance is invalid. Ex. the Baudrate is less than or equal to zero");
            }
            catch (ArgumentException)
            {
                Debug.WriteLine("The port name does not begin with 'COM'");
            }
            catch (IOException)
            {
                Debug.WriteLine("The port is in an invalid state");
            }
            catch (InvalidOperationException)
            {
                Debug.WriteLine("The port is already open");
            }
            catch (Exception)
            {
                Debug.WriteLine("Connection couldn't be opened");
            }
        }

        protected virtual void OnDirectionChanged(Directions dir)
        {
            DirectionEventArgs dea = new DirectionEventArgs(dir);
            DirectionChanged?.Invoke(this, dea);
        }
        protected virtual void OnFryButtonPressed(FryButtons buttons)
        {
            ButtonEventArgs<FryButtons> fea = new ButtonEventArgs<FryButtons>(buttons);
            FryButtonPressed?.Invoke(this, fea);
        }
        protected virtual void OnPotButtonPressed(PotButtons button)
        {
            ButtonEventArgs<PotButtons> pea = new ButtonEventArgs<PotButtons>(button);
            PotButtonPressed?.Invoke(this, pea);
        }
    }
}
