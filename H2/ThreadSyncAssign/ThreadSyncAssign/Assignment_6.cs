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
                lock (_lock)
                {
                    try
                    {

                        Monitor.Enter(forks[philonum]);
                        Console.WriteLine($"{Thread.CurrentThread.Name} is taking the fork");
                        forks[philonum] = true;
                        if (forks[(philonum + 1) % 5] == false)
                        {
                            try
                            {
                                forks[(philonum + 1) % 5] = true;
                                Monitor.Enter(forks[(philonum + 1) % 5]);
                                Console.WriteLine($"{Thread.CurrentThread.Name} is taking the other fork");
                                Eating();

                            }
                            finally
                            {
                                forks[(philonum + 1) % 5] = false;
                                Monitor.Exit(forks[(philonum + 1) % 5]);
                            }
                        }


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    finally
                    {
                        forks[philonum] = false;
                        Monitor.Exit(forks[philonum]);
                    }
                }

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
