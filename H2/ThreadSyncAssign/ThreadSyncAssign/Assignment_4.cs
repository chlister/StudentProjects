using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncAssign
{
    class Assignment_4
    {
        static void Main(string[] args)
        {
            Buffer buf = new Buffer();
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
    class Buffer
    {
        object _lock = new object();
        public int BufferCount { get; set; }
        private int MaxBuffer { get; } = 10;
        public int MinBuffer { get; } = 0;

        public Buffer()
        {

        }

        public void AddCount(object obj)
        {
            while (true)
            {
                if (BufferCount == MaxBuffer)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} didn't get to produce any buffer. Size: {BufferCount}");
                    Thread.Sleep(50);
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} added to buffer. Current buffer: {BufferCount}");
                    BufferCount++;
                }

                //Monitor.Enter(_lock);
                //try
                //{
                //    Thread.Sleep(1000);
                //    Console.WriteLine("Buffer added");
                //    BufferCount++;
                //}
                //finally
                //{
                //    Monitor.Exit(_lock);
                //}
            }
        }
        public void DecreaseCount(object obj)
        {
            while (true)
            {
                if (BufferCount == MinBuffer)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} didn't get to consume any buffer. Size: {BufferCount}");
                    Thread.Sleep(50);
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} consumed buffer. Current buffer: {BufferCount}");
                    BufferCount--;
                }

                //Monitor.Enter(_lock);
                //try
                //{
                //    Thread.Sleep(500);
                //    if (BufferCount == 0)
                //    {
                //        Console.WriteLine("No more buffer left!");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Buffer taken");
                //        BufferCount--;
                //    }

                //}
                //finally
                //{
                //    Monitor.Exit(_lock);
                //}
            }
        }
    }

}
