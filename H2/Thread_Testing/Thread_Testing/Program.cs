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
        static Queue<int> bottles = new Queue<int>();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Producer);
            Thread t2 = new Thread(Consumer);
            t1.Start();
            t2.Start();



            t1.Join();
            t2.Join();
            Console.ReadLine();
        }
        static void Producer()
        {
            // Gives bottles to the machine
            lock (bottles)
            {
                Thread.Sleep(1000);

                Console.WriteLine("I have got bottles for you");
                Monitor.Enter(bottles);
                for (int i = 0; i < limit; i++)
                {

                    bottles.Enqueue(limit);
                }

                Monitor.PulseAll(bottles);
                Console.WriteLine(bottles.Count);
                Monitor.Exit(bottles);

            }
            //Console.WriteLine("");
        }
        static void Consumer()
        {
            int reciept = 0;
            // Will run until there are no bottles
            do
            {
                // Consumes bottles from the machine into reciept
                lock (bottles)
                {
                    // checking if the bottles have been filled in
                    if (bottles.Count == 0)
                    {
                        Monitor.Enter(bottles);
                        Console.WriteLine("No bottles ! ill wait!");
                        // Waiting till bottles has been inserted
                        Monitor.Wait(bottles);
                        Monitor.Exit(bottles);
                    }
                    Console.WriteLine("Ill take you bottles");
                    Thread.Sleep(1000);
                    int amount = bottles.Count;

                    Monitor.Enter(bottles);
                    for (int i = 0; i < amount; i++)
                    {
                        reciept++;
                        Console.WriteLine("Adding bottle to the reciept");
                        bottles.Dequeue();
                        Thread.Sleep(1000);
                    }
                    Monitor.Exit(bottles);
                    Console.WriteLine(bottles.Count);

                }
            } while (bottles.Count != 0);
            Console.WriteLine("Printing reciept for " + reciept + " bottles.");
        }
    }
}