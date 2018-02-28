using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolingAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPoolDemo tpd = new ThreadPoolDemo();
            for (int i = 0; i < 2; i++)
            {
                // WaitCallBack er for at tråden venter på at eksekvere til forrige tråd er færdig.
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task1));
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.task2));
                // WaitCallBack bliver kaldt implisit derfor er det ikke nødvendigt mere
                ThreadPool.QueueUserWorkItem(tpd.task1);
                ThreadPool.QueueUserWorkItem(tpd.task2);
            }

            Console.Read();

        }
        public class ThreadPoolDemo
        {
            public void task1(object obj)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Task 1 is being executed");
                }
            }
            public void task2(object obj)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Task 2 is being executed");
                }
            }
        }
    }
}