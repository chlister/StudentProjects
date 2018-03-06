using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Testing
{
    class Program
    {
        static int limit = 15;
        static Queue<int> bottles = new Queue<int>(limit);

        static void Main(string[] args)
        {
            if (bottles.Count <= limit)
            {

            }
            Thread t1 = new Thread(Producer);
            Thread t2 = new Thread(Consumer);
            //Thread t3 = new Thread(NoSafety);
            t1.Start();
            t2.Start();
            //t3.Start();
            t1.Join();
            t2.Join();
            Console.ReadLine();
        }
        static void Producer()
        {
            // Gives bottles to the machine
            while (true)
            {
                lock (bottles)
                {
                    bottles.Enqueue(22);
                    Thread.Sleep(1000);

                    Console.WriteLine("Ill give you bottles");
                    Console.Beep();
                    Monitor.Enter(bottles);
                    if (bottles.Count > 0)
                    {
                        for (int i = 0; i < limit - bottles.Count; i++)
                        {

                            bottles.Enqueue(limit);
                        }
                    }
                    Monitor.PulseAll(bottles);
                    Monitor.Exit(bottles);
                    Console.WriteLine(bottles.Count);
                }
            }
            //Console.WriteLine("");
        }
        static void Consumer()
        {
            // Consumes bottles from the machine into reciept
            while (true)
            {
                lock (bottles)
                {

                    if (bottles.Count == 0)
                    {
                        Monitor.Enter(bottles);
                        Console.WriteLine("No botttles ! ill wait!");
                        Monitor.Wait(bottles);
                        Monitor.Exit(bottles);
                    }
                    Console.WriteLine("Ill take you bottles");
                    bottles.Dequeue();
                    Console.WriteLine(bottles.Count);

                }
            }
        }
    }
}