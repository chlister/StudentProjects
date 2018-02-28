using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolingAssign
{
    class Assignment_3
    {
        static void Main(string[] args)
        {
            ThreadTesting_1();
            Console.ReadLine();
            /** //Metode                //  Beskrivelse
             * Start()                      Starter en tråd i den metode som gives i constructeren  
             * Sleep()                      Sætter en tråd til at 'sove' i det givne antal miliseconder
             * Suspend()                    Stopper en tråd midlertidigt
             * Resume()                     Sætter en tråd igang igen efter et suspend
             * Abort()                      Sætter en tråd til at stoppe
             * Join()                       Lader Mainthread vente på en tråd, dvs. at den tjekker op om IsAlive == false
             * */
        }

        private static void ThreadTesting_1()
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(Process_States_Test);
            }
        }

        private static void Process_States_Test(object state)
        {
            Console.WriteLine("Thread num: {1}, IsAlive: {0}",
                Thread.CurrentThread.IsAlive,
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread num: {1}, IsBackground: {0}",
                Thread.CurrentThread.IsBackground,
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread num: {1}, Priority: {0}",
                Thread.CurrentThread.Priority,
                Thread.CurrentThread.ManagedThreadId);

        }
    }
}
