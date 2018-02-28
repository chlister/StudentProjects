using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadPoolingAssign
{
    class Assignment_2
    {
        static void Main(string[] args)
        {
            
            Stopwatch mywatch = new Stopwatch(); // Constructing our stopwatch
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start(); // Starting stopwatch
            ProcessWithThreadPoolMethod(); // using threadpool
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString()); // showing the time used to console
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod(); // using threads without pool
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString()); // showing the time used to console
            Console.ReadLine();
        }

        static void Process(object callBack)
        {
            // eksekveringen for Threadpool ser ud til at stige linært, hvorimod thread bliver eksponentielt højere
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
