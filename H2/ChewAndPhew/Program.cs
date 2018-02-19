using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewAndPhew
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.HelpLink);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
            }


            Console.ReadLine();
        }

        private static void Start()
        {
            string choice;

            do
            {
                Console.Clear();
                Console.WriteLine("You stand at the GumMachine");
                Console.WriteLine($"It looks like there is {GumMachine.Instance.Gums.Count} pieces of gums left");
                Console.WriteLine("1) Take a piece of Gum");
                Console.WriteLine("2) Refill the machine with gum");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        if (GumMachine.Instance.Gums.Count != 0)
                        {
                            Gum gum = GumMachine.Instance.GetGum();
                            Console.WriteLine(gum.ToString());
                        }
                        else
                        {
                            Console.WriteLine("No more gum - Please refill");
                        }
                        break;
                    case "2":
                        Console.WriteLine(GumMachine.Instance.Refillmachine());
                        break;
                    default:
                        Console.WriteLine("What are you doing?");
                        break;
                }
                Console.ReadLine();
            } while (true);

        }
    }
}
