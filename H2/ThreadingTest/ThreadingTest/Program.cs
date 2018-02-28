using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Assign_1);
            t.Start();
            Thread b = new Thread(Assign_2);
            b.Start();

            Console.ReadLine();
        }


        static void Assign_1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Trådning er nemt!");
                // Thread.Sleep kan være smart for os så vi tvinger computeren til at holde en pause og lave den anden tråd arbejde.
                Thread.Sleep(1000);
            }
        }
        private static void Assign_2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde!");
                Thread.Sleep(1000);
            }
        }
    }
}
