using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSyncAssign.Assignment_1
{
    class Assignment_1
    {

        static void Main(string[] args)
        {
            MoniClass mon = new MoniClass();
            Thread t1 = new Thread(mon.CounterUp);
            Thread t2 = new Thread(mon.CounterDown);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
    class MoniClass
    {
        public int Counter { get; set; } = 0;
        object _lock = new object();

        public MoniClass()
        {

        }
        public void CounterUp()
        {
            while (true)
            {

                Monitor.Enter(_lock);
                try
                {
                    Counter++;
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} have incremented the counter to: {Counter}");
                }
                finally
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is leaving the method");
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(1000);
            }

        }
        public void CounterDown()
        {
            while (true)
            {

                Monitor.Enter(_lock);
                try
                {
                    Counter--;
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} have decremented the counter to: {Counter}");
                }
                finally
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is leaving the method");
                    Monitor.Exit(_lock);
                }

                Thread.Sleep(1000);
            }
        }

    }
}
