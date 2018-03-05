using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadSyncAssign
{
    class Assignment_5
    {
        static void Main(string[] args)
        {
            MonBuffer buf = new MonBuffer();
            //ThreadPool.QueueUserWorkItem(buf.AddCount);
            //ThreadPool.QueueUserWorkItem(buf.DecreaseCount);
            Thread Producer = new Thread(buf.AddCount);
            Thread Consumer = new Thread(buf.DecreaseCount);
            Producer.Name = "Producer";
            Consumer.Name = "Consumer";
            Producer.Start();
            Consumer.Start();
            Console.ReadLine();
        }

    }
    class MonBuffer
    {
        object _lock = new object();
        public int Stock { get; set; } = 0;
        private int MaxBuffer { get; } = 10;

        public MonBuffer()
        {

        }

        public void AddCount(object obj)
        {
            while (true)
            {
                lock (_lock)
                {
                    while (Stock == MaxBuffer)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is waiting to refill. Current stock: {Stock}");
                        Monitor.Wait(_lock);
                    }
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is refilling the stock. Current stock: {Stock}");
                    Stock ++;
                    Monitor.PulseAll(_lock);
                }
            }
        }
        public void DecreaseCount(object obj)
        {
            while (true)
            {
                lock (_lock)
                {
                    while (Stock == 0)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} is waiting for a refill. Current stock: {Stock}");
                        Monitor.Wait(_lock);
                    }
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} has taken another from stock. Current stock: {Stock}");
                    Stock--;
                    Monitor.PulseAll(_lock);
                }
            }
        }


    }

}

