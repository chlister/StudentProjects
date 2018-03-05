using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Testing
{
    class QuickTest
    {
        static object _lock = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Looper);
            Thread t2 = new Thread(Looper);
            t1.Start();
            t2.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main number: " + i);
            }
            Console.ReadLine();
        }

        private static void Looper()
        {
            lock (_lock)
            {

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " number: " + i);
                }
            }
        }
    }
}
