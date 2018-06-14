using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ArenaRPG.Annotations;

namespace ArenaRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            for (int i = 0; i < 100; i++)
            {
                counter++;
                if (counter == 50)
                {
                    
                }
            }

            Console.WriteLine(counter);

            Console.WriteLine("Hello");
            Console.ReadLine();
        }

        
    }

    public class Counter 
    {
        public event EventHandler ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class Display
    {
        public Display()
        {

        }
    }
}
