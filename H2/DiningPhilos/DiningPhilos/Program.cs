using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DiningPhilos
{
    class Program
    {
        static int numberofPhilo = 5;
        static bool[] forks = new bool[numberofPhilo];
        static Thread[] philos = new Thread[numberofPhilo];
        static void Main(string[] args)
        {
            foreach (var item in forks)
            {
                Console.WriteLine(item.ToString());
            }
            for (int i = 0; i < numberofPhilo; i++)
            {
                int temp = i;
                Console.WriteLine(temp + "");
                philos[temp] = new Thread(LifeOfPhilo);
                philos[temp].Name = "Philo_" + temp;
                philos[temp].Start(temp);
                //philos[temp].Join();
            }

            Console.ReadLine();
        }
        public static void LifeOfPhilo(object philonum)
        {
            object _lock = new object();
            int timesEatin = 0;
            int philo = (int)philonum;
            int forkPrim = philo;
            int forkSec = (philo + 1) % 5;
            do
            {
                lock ((object)forks[forkPrim])
                {
                    // check if primary fork is available
                    if (forks[forkPrim] == false)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} I have fork number : {forkPrim}!");
                        // Set it to true if it's usable
                        forks[forkPrim] = true;
                        // Lock the fork
                        if (Monitor.TryEnter(forks[forkPrim]) == true)
                        {
                            try
                            {
                                lock ((object)forks[forkSec])
                                {
                                    // Check if secondary fork is available
                                    if (forks[forkSec] == false)
                                    {
                                        Console.WriteLine($"{Thread.CurrentThread.Name} I have fork number : {forkSec}!");
                                        // Set it to true if it's usable
                                        forks[forkSec] = true;
                                        // lock the other fork
                                        if (Monitor.TryEnter(forks[forkSec]) == true)
                                        {
                                            try
                                            {
                                                // eat my philo
                                                Console.WriteLine($"{Thread.CurrentThread.Name} I have both forks!");
                                                Eat(ref timesEatin);
                                            }
                                            finally
                                            {
                                                Console.WriteLine($"{Thread.CurrentThread.Name} Dropping my secondary fork");
                                                //Monitor.PulseAll(forks[forkSec]);
                                                //Monitor.Exit(forks[forkSec]);
                                                forks[forkSec] = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{Thread.CurrentThread.Name} couldn't get the secondary fork: {forkSec}");
                                        }
                                    }
                                }
                            }
                            finally
                            {
                                Console.WriteLine($"{Thread.CurrentThread.Name} Dropping my primary fork");
                                //Monitor.PulseAll(forks[forkSec]);
                                //Monitor.Exit(forks[forkPrim]);
                                forks[forkPrim] = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} couldn't get the primary fork: {forkPrim}");
                    }
                }
                Thinking();
            } while (true);
        }
        public static void Eat(ref int times)
        {
            times++;
            Console.WriteLine($"{Thread.CurrentThread.Name} nom nom i have eaten {times}");
            Thread.Sleep(500);

        }
        public static void Thinking()
        {
            Random rnd = new Random();
            int time = rnd.Next(2000, 4000);
            Console.WriteLine($"{Thread.CurrentThread.Name} I am thinking...");
            Thread.Sleep(time);
        }
    }
}
