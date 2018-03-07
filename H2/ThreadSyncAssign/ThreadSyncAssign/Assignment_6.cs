using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSyncAssign
{
    class Assignment_6
    {
        static bool[] forks = new bool[5];
        static Random rnd = new Random();
        static int numPhilos = 5;

        static void Main(string[] args)
        {
            for (int i = 0; i < numPhilos; i++)
            {
                int temp = i;
                Thread philo = new Thread(() => LifeOfPhilo(temp));
                philo.Name = "Philosopher_" + temp;
                philo.Start();
                philo.Join();
            }

            Console.ReadLine();
        }

        static void LifeOfPhilo(int philonum)
        {
            object _lock = new object();
            while (true)
            {
                Thinking();
                // Philo needs to eat
                // Needs two forks
                // Check if fork to the right is available (forks[philonum])

                //try
                //{
                if (Monitor.TryEnter(forks[philonum]))
                {
                    forks[philonum] = true;
                    Console.WriteLine($"{Thread.CurrentThread.Name} is taking the fork {philonum}");
                    Thread.Sleep(500);
                    if (Monitor.TryEnter(forks[(philonum + 1) % 4]))
                    {
                        // Bool sets to true while fork is in use
                        forks[(philonum + 1) % 5] = true;
                        Console.WriteLine($"{Thread.CurrentThread.Name} is taking the other fork {(philonum + 1) % 4}");
                        // Philo is eating
                        Console.WriteLine($"{Thread.CurrentThread.Name} is eating");
                        Thread.Sleep(500);
                        //Eating();
                        Console.WriteLine($"{Thread.CurrentThread.Name} is dropping fork {(philonum + 1) % 4}");
                        // Philo is done with the fork 
                        forks[(philonum + 1) % 4] = false;
                        // Drops the fork so it can be used
                        Monitor.Exit(forks[(philonum + 1) % 4]);

                    }
                    Console.WriteLine($"{Thread.CurrentThread.Name} is dropping fork {philonum}");
                    // Set bool to false - fork is no longer in use
                    forks[philonum] = false;
                    // Drops the primary fork
                    Monitor.Exit(forks[philonum]);
                }

                //}
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //    Console.ReadLine();
                //}


            }
        }


        static void Eating()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is eating");
            Thread.Sleep(500);
        }

        static void Thinking()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is thinking");
            int time = rnd.Next(2500);
            Thread.Sleep(time);
        }
    }
}
