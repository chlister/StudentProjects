using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thread_Testing.Models;

namespace Thread_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start another class
            MyThread producer = new MyThread("Producer");
            MyThread consumer = new MyThread("Consumer");
            Console.ReadLine();
        }

    }
    public class MyThread
    {
        object _lock = new object();
        public Thread thread;
        public MyThread(string _name)
        {
            thread = new Thread(new ThreadStart(this.Run));
            thread.Name = _name;
            thread.Start();
        }
        void Run()
        {
            while (true)
            {

                if (thread.Name == "Producer")
                {
                    FillMachine();
                }
                else
                {
                    ConsumeProducts();
                }
            }
        }
        public void FillMachine()
        {
            ProductFactory pf = new ProductFactory();
            //Monitor.Enter(_lock);
            lock (_lock)
                // Works fine but i need to stop the thread when machine is filled
                //{
                if (VendingMachine.Instance.Beers.Count() < VendingMachine.Instance.RowSize)
                {
                    // I can typecast the object i get in return because i know it's the right type
                    VendingMachine.Instance.Beers.Enqueue((Beer)pf.CreateProduct("Beer"));
                    Console.WriteLine("Current Beer count: " + VendingMachine.Instance.Beers.Count());
                }
            if (VendingMachine.Instance.Sodas.Count() < VendingMachine.Instance.RowSize)
            {
                VendingMachine.Instance.Sodas.Enqueue((Soda)pf.CreateProduct("Soda"));
                Console.WriteLine("Current soda count:  " + VendingMachine.Instance.Sodas.Count());
            }
            if (VendingMachine.Instance.Sodas.Count() == VendingMachine.Instance.RowSize && VendingMachine.Instance.Beers.Count() == VendingMachine.Instance.RowSize)
            {
                Console.WriteLine("Machine is full - I am waiting");
                Monitor.Wait(_lock);
            }
            Console.WriteLine("Producer is sleeping");
            Thread.Sleep(2000);
            Console.WriteLine("Producer pulses all");
            Monitor.PulseAll(_lock);
            //}

            Console.WriteLine(Thread.CurrentThread.Name + "I am exiting the lock");
            //Monitor.Exit(_lock);
        }
        public void ConsumeProducts()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);

            lock (_lock)
                //Monitor.Enter(_lock);
                //{
                if (num == 1)
                {
                    if (VendingMachine.Instance.Beers.Count() > 0)
                    {
                        // I can typecast the object i get in return because i know it's the right type
                        Console.WriteLine("I got this Beer: " + VendingMachine.Instance.Beers.Dequeue().Name);
                    }
                    else
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " Hello?");
                        Monitor.Wait(_lock);
                    }
                }
                else
                {
                    if (VendingMachine.Instance.Sodas.Count() > 0)
                    {
                        Console.WriteLine("I got this soda: " + VendingMachine.Instance.Sodas.Dequeue().Name);
                    }
                    else
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " Hello?");
                        Monitor.Wait(_lock);
                    }
                }
            Monitor.PulseAll(_lock);
            Console.WriteLine("Consumer is sleeping");
            Thread.Sleep(10000);
            //}

            Console.WriteLine(Thread.CurrentThread.Name + "I am exiting the lock");
            //Monitor.Exit(_lock);
        }
    }
}