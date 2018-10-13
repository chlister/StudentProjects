using System;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading.Tasks;
using CustomControl.Input;
using CustomControl.Event;
using System.Collections.Generic;
using System.Threading;

namespace CustomControl
{
    public class ConnectSerial
    {
        #region Fields & Properties

        // needed for opening the COM-port
        private SerialPort _serialPort;
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
        #endregion

        #region Eventhandlers

        // delegate Eventhandlers 
        public event EventHandler<FryEventArgs> FryStateChanged;
        public event EventHandler<PotEventArgs> PotStateChanged;
        public event EventHandler<CuttingEventArgs> CuttingAction;
        public event EventHandler<DirectionEventArgs> DirectionChanged;
        public event EventHandler<ButtonEventArgs<CuttingButtons>> CuttingButtonPressed;
        public event EventHandler<ButtonEventArgs<FryButtons>> FryButtonPressed;
        public event EventHandler<ButtonEventArgs<AssemblerButtons>> AssemblerButtonPressed;
        public event EventHandler<ButtonEventArgs<PotButtons>> PotButtonPressed;

        #endregion

        public ConnectSerial()
        {
            _serialPort = new SerialPort();
        }

        /// <summary>
        /// Reads the input from the port
        /// </summary>
        private void ReadInput()
        {
            string serialInput;
            while (true)
            {
                serialInput = _serialPort.ReadExisting();
                if (serialInput.Contains("C"))
                {
                    //GetCuttingInput(serialInput);
                    Task.Run(() => GetCuttingInput(serialInput));
                }
                if (serialInput.Contains("J"))
                {
                    Task.Run(() => GetAssemblerInput(serialInput));
                }
                if (serialInput.Contains("F"))
                {
                    Task.Run(() => GetFryInput(serialInput));
                }
                if (serialInput.Contains("P"))
                {
                    Task.Run(() => GetPotInput(serialInput));
                }

                Thread.Sleep(30);
            }
        }

        /// <summary>
        /// Handles the input concerning the Pot
        /// </summary>
        /// <param name="serialInput"></param>
        private void GetPotInput(string serialInput)
        {
            List<string> inputs = new List<string>();
            for (int i = 0; i <= serialInput.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        inputs.Add("" + serialInput[i - 2] + serialInput[i - 1]);
                    }
                }
            }
            foreach (var item in inputs)
            {
                switch (item)
                {
                    case "P0":
                        OnPotButtonPressed(PotButtons.B0);
                        break;
                    case "P1":
                        OnPotButtonPressed(PotButtons.B1);
                        break;
                    case "PT":
                        OnPotStateChanged(PotState.LidOn);
                        break;
                    case "PF":
                        OnPotStateChanged(PotState.LidOff);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the input concerning the Fryingpan
        /// </summary>
        /// <param name="serialInput"></param>
        private void GetFryInput(string serialInput)
        {
            List<string> inputs = new List<string>();
            for (int i = 0; i <= serialInput.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        inputs.Add("" + serialInput[i - 2] + serialInput[i - 1]);
                    }
                }
            }
            foreach (var item in inputs)
            {
                switch (item)
                {
                    case "F0":
                        OnFryButtonPressed(FryButtons.B0);
                        break;
                    case "F1":
                        OnFryButtonPressed(FryButtons.B1);
                        break;
                    case "F2":
                        OnFryButtonPressed(FryButtons.B2);
                        break;
                    // TODO: Missing function
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the input concerning the assembler
        /// </summary>
        /// <param name="serialInput"></param>
        private void GetAssemblerInput(string serialInput)
        {
            List<string> inputs = new List<string>();
            for (int i = 0; i <= serialInput.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        inputs.Add("" + serialInput[i - 2] + serialInput[i - 1]);
                    }
                }
            }
            foreach (var item in inputs)
            {
                switch (item)
                {
                    case "JU":
                        OnDirectionChanged(Directions.Up);
                        break;
                    case "JD":
                        OnDirectionChanged(Directions.Down);
                        break;
                    case "JR":
                        OnDirectionChanged(Directions.Right);
                        break;
                    case "JL":
                        OnDirectionChanged(Directions.Left);
                        break;
                    case "J0":
                        OnAssemblerButtonPressed(AssemblerButtons.B0);
                        break;
                    case "J1":
                        OnAssemblerButtonPressed(AssemblerButtons.B1);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the input concerning the cuttingboard
        /// </summary>
        /// <param name="serialInput"></param>
        private void GetCuttingInput(string serialInput)
        {
            List<string> inputs = new List<string>();
            for (int i = 0; i <= serialInput.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 2 == 0)
                    {
                        inputs.Add("" + serialInput[i - 2] + serialInput[i - 1]);
                    }
                }
            }
            foreach (var item in inputs)
            {
                switch (item)
                {
                    case "C0":
                        OnCuttingButtonPressed(CuttingButtons.B0);
                        break;
                    case "C1":
                        OnCuttingButtonPressed(CuttingButtons.B1);
                        break;
                    case "C2":
                        OnCuttingButtonPressed(CuttingButtons.B2);
                        break;
                    case "C3":
                        OnCuttingButtonPressed(CuttingButtons.B3);
                        break;
                    case "CS":
                        OnCuttingAction(CuttingActions.Cutting);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Opens a connection to the first available COM port 
        /// This method assumes that there is only one COM port open at the time.
        /// After openening the port successfully a new thread reads the input from 
        /// the COM port. 
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (!IsOpen)
                {
                    PortName = SerialPort.GetPortNames()[0]; 
                    BaudRate = 9600;
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

        #region Event raisers


        protected virtual void OnCuttingAction(CuttingActions cutting)
        {
            CuttingEventArgs cea = new CuttingEventArgs(cutting);
            CuttingAction?.Invoke(this, cea);
        }
        protected virtual void OnCuttingButtonPressed(CuttingButtons button)
        {
            ButtonEventArgs<CuttingButtons> bea = new ButtonEventArgs<CuttingButtons>(button);
            CuttingButtonPressed?.Invoke(this, bea);
        }
        protected virtual void OnPotStateChanged(PotState state)
        {
            PotEventArgs pea = new PotEventArgs(state);
            PotStateChanged?.Invoke(this, pea);
        } 
        protected virtual void OnDirectionChanged(Directions dir)
        {
            DirectionEventArgs dea = new DirectionEventArgs(dir);
            DirectionChanged?.Invoke(this, dea);
        }
        protected virtual void OnFryButtonPressed(FryButtons buttons)
        {
            ButtonEventArgs<FryButtons> bea = new ButtonEventArgs<FryButtons>(buttons);
            FryButtonPressed?.Invoke(this, bea);
        }
        protected virtual void OnAssemblerButtonPressed(AssemblerButtons buttons)
        {
            ButtonEventArgs<AssemblerButtons> bea = new ButtonEventArgs<AssemblerButtons>(buttons);
            AssemblerButtonPressed?.Invoke(this, bea);
        }
        protected virtual void OnPotButtonPressed(PotButtons button)
        {
            ButtonEventArgs<PotButtons> bea = new ButtonEventArgs<PotButtons>(button);
            PotButtonPressed?.Invoke(this, bea);
        }
        #endregion
    }
}
