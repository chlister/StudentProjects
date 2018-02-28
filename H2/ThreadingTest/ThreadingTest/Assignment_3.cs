using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingTest
{
    /// <summary>
    /// Testing multiple strings one monitering another
    /// </summary>
    class Assignment_3
    {
        static int temperature = 0;
        static int alarm = 0;

        static void Main(string[] args)
        {
            Thread a = new Thread(GenTemp);
            Thread b = new Thread(TempMonitor);
            a.Name = "Temperature_Gen";
            b.Name = "Monitor";
            a.Start();
            b.Start();

            Console.ReadLine();
        }

        private static void TempMonitor()
        {
            while (alarm < 3)
            {

                if (temperature > 100 || temperature < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alert Temperatur = " + temperature);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    alarm++;
                    
                }
                else
                {
                    Console.WriteLine("Current temperature: " + temperature);
                }
                Thread.Sleep(2000);
            }
            Console.WriteLine("Threads: {0} has terminated",
                Thread.CurrentThread.Name);
        }

        private static void GenTemp()
        {
            while (alarm < 3)
            {

                Random rnd = new Random();
                int temp = rnd.Next(-20, 120);
                temperature = temp;
                Thread.Sleep(2000);
            }
            Console.WriteLine("Threads: {0} has terminated",
                Thread.CurrentThread.Name);
        }
    }
}
