using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArduInput
{
    class Program
    {
        static SerialPort _serialPort;

        static void Main(string[] args)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM4";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            while (true)
            {
                string a = _serialPort.ReadExisting();
                ReadInput(a);
                //Console.WriteLine(a);
                Thread.Sleep(200);
            }
        }

        private async static void ReadInput(string a)
        {
            await Task.Run(() =>
            {
                if (a.Contains("DOWN"))
                {
                    Console.WriteLine("Down was pressed");
                }
                if (a.Contains("RIGHT"))
                {
                    Console.WriteLine("Right was pressed");
                }
                if (a.Contains("UP"))
                {
                    Console.WriteLine("Up was pressed");
                }
                if (a.Contains("LEFT"))
                {
                    Console.WriteLine("Left was pressed");
                }
            });
            await Task.Run(() =>
            {
                if (a.Contains("Direction:"))
                {
                    if (a.Contains("Right"))
                    {
                        Console.WriteLine("Moving Right!");
                    }
                    if (a.Contains("Left"))
                    {
                        Console.WriteLine("Moving Left!");
                    }
                    if (a.Contains("Up"))
                    {
                        Console.WriteLine("Moving Up!");
                    }
                    if (a.Contains("Down"))
                    {
                        Console.WriteLine("Moving Down!");
                    }
                }
            });
        }
    }
}
