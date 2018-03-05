using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadSyncAssign
{
    class Assignment_2and3
    {
        static void Main(string[] args)
        {
            Writer wr = new Writer();
            Thread t1 = new Thread(() => wr.WriteChar('#'));
            t1.Start();
            Thread t2 = new Thread(() => wr.WriteChar('*'));
            t2.Start();
        }
    }
    class Writer
    {
        int count = 0;
        object _lock = new object();

        public Writer()
        {

        }
        public void WriteChar(char ch)
        {
            while (true)
            {
                Monitor.Enter(_lock);
                try
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write(ch);
                        count++;
                    }
                    Console.WriteLine(count);
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
