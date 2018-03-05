using System;
using System.Threading;
namespace WaitndPulesMethod
{
    class PingPong
    {
        public void ping(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    //ball halts.
                    Monitor.Pulse(this); // notify any waiting threads
                    return;
                }
                Console.Write("Ping ");
                Monitor.Pulse(this); // let pong() run
                Monitor.Wait(this); // wait for pong() to complete
            }
        }
        public void pong(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    //ball halts.
                    Monitor.Pulse(this); // notify any waiting threads
                    return;
                }
                Console.WriteLine("Pong ");
                Monitor.Pulse(this); // let ping() run
                Monitor.Wait(this); // wait for ping() to complete
            }
        }
    }
    class MyThread
    {
        public Thread thread;
        PingPong pingpongObject;
        //construct a new thread.
        public MyThread(string name, PingPong pp)
        {
            thread = new Thread(new ThreadStart(this.run));
            pingpongObject = pp;
            thread.Name = name;
            thread.Start();
        }
        //Begin execution of new thread.
        void run()
        {
            if (thread.Name == "Ping")
            {
                for (int i = 0; i < 5; i++)
                    pingpongObject.ping(true);
                pingpongObject.ping(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    pingpongObject.pong(true);
                pingpongObject.pong(false);
            }
        }
    }
    class BouncingBall
    {
        public static void Main()
        {
            PingPong pp = new PingPong();
            Console.WriteLine("The Ball is dropped... \n");
            MyThread mythread1 = new MyThread("Ping", pp);
            MyThread mythread2 = new MyThread("Pong", pp);
            mythread1.thread.Join();
            mythread2.thread.Join();
            Console.WriteLine("\nThe Ball Stops Bouncing.");
            Console.Read();
        }
    }
}