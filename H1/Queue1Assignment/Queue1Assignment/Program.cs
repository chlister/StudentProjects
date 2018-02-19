using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queue1Assignment
{
    class Program
    {
        public static Store store = new Store();
        public static Queue<string> queue = new Queue<string>();
        public static Random rnd = new Random();
        public static string[] names = new string[] { "John", "James", "Joe", "Laura", "Sille", "Jenny", "Lis", "Leo", "Damian", "Brok", "Marc", "Camilla", "Mikkel", "David", "Nikolaj", "Simon", "Dan", "Thomas", "Anita", "Katrine", "Trine", "Kirstine", "Maja", "Pia", "Inge", };
        static void Main(string[] args)
        {
            #region Adding wares to warehouse -- Test
            store.CreateNewFruit("Banana", 5);
            store.CreateNewFruit("Banana", 5);
            store.CreateNewFruit("Apple", 10);
            store.CreateNewFruit("Banana", 5);
            store.CreateNewMeat("Steak", 50);
            store.CreateNewMeat("Chicken", 45);
            store.CreateNewBeverage("Water", 15);
            store.CreateNewBeverage("Smoothie", 30);
            store.CreateNewBeverage("Beer", 25);
            #endregion

            MainMenu();
        }
        static void AddWares()
        {
            bool inWarehouse = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("=                     =");
                Console.WriteLine("=      Warehouse      =");
                Console.WriteLine("=        /  \\         =");
                Console.WriteLine("=       | [] |        =");
                Console.WriteLine("=======================");
                try
                {
                    Console.WriteLine("1) Add Fruit");
                    Console.WriteLine("2) Add Meat");
                    Console.WriteLine("3) Add Beverage");
                    Console.WriteLine("9) Leave Warehouse");
                    string input = Console.ReadKey(true).KeyChar.ToString();
                    switch (input)
                    {
                        case "1":
                            AddFruitGUI();
                            break;
                        case "2":
                            AddMeatGUI();
                            break;
                        case "3":
                            AddBeverageGUI();
                            break;
                        case "9":
                            inWarehouse = false;
                            break;
                        default:
                            Console.WriteLine("Please choose a valid input");
                            Console.ReadLine();
                            break;
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input invalid. Try again");
                    Console.WriteLine("Please try again");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                }
            } while (inWarehouse);
            Console.ReadLine();
        }
        static void AddFruitGUI()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("=                     =");
            Console.WriteLine("=      Add wares      =");
            Console.WriteLine("=        Fruit        =");
            Console.WriteLine("=                     =");
            Console.WriteLine("=======================");
            Console.ReadLine();

        }
        static void AddMeatGUI()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("=                     =");
            Console.WriteLine("=      Add wares      =");
            Console.WriteLine("=        Meat         =");
            Console.WriteLine("=                     =");
            Console.WriteLine("=======================");
            Console.ReadLine();
        }
        static void AddBeverageGUI()
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("=                     =");
            Console.WriteLine("=      Add wares      =");
            Console.WriteLine("=      Beverage       =");
            Console.WriteLine("=                     =");
            Console.WriteLine("=======================");
            Console.ReadLine();
        }
        static void StoreInventory()
        {
            bool inInventory = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("=                     =");
                Console.WriteLine("=   Store Inventory   =");
                Console.WriteLine("=     |___[]|_[]__|   =");
                Console.WriteLine("=     |_[]__|[]___|   =");
                Console.WriteLine("=======================");
                Console.WriteLine("What wares are you looking for?");
                Console.WriteLine("1) Fruit");
                Console.WriteLine("2) Meat");
                Console.WriteLine("3) Beverages");
                Console.WriteLine("9) Leave shelfs");
                string input = Console.ReadKey(true).KeyChar.ToString();
                if (input == "9")
                {
                    inInventory = false;
                }
                store.PrintWares(input);
            } while (inInventory);
            
        }
        static void CheckOut()
        {
            bool inQueue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("=                     =");
                Console.WriteLine("=      The Queue      =");
                Console.WriteLine("=                     =");
                Console.WriteLine("=                     =");
                Console.WriteLine("=======================");
                int rndNum = rnd.Next(1, 10);
                for (int i = 0; i < rndNum; i++)
                {
                    string name = names[rnd.Next(0, names.Count())];
                    queue.Enqueue(name);
                }
                queue.Enqueue("You");
                Console.WriteLine("You are number: {0} in the queue", queue.Count());
                foreach (string item in queue)
                {
                    int num = 0;
                    Console.WriteLine("Queue pos: {0}. Name: {1}",num,item);
                    num++;
                }
                while (queue.Count != 1)
                {
                    // set timer
                    int timer = rnd.Next(50, 200);
                    for (int i = 0; i < timer; i++)
                    {
                        Thread.Sleep(20);
                    }
                    // remove customer
                    string person = queue.Dequeue();
                    // Write to console that customer is leaving the line --> new queue number
                    Console.WriteLine("{0} has left the queue, next in line is {1}. You're number {2}", person, queue.Peek(), queue.Count());
                }
                Console.WriteLine("Now it's {0}", queue.Dequeue());
                Console.ReadLine();
                inQueue = false;
            } while (inQueue);
        }
        static void MainMenu()
        {
            bool inMainMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("=                     =");
                Console.WriteLine("=     The Grocery     =");
                Console.WriteLine("=        Store        =");
                Console.WriteLine("=                     =");
                Console.WriteLine("=======================");
                Console.WriteLine("1) Check inventory");
                Console.WriteLine("2) Look at wares");
                Console.WriteLine("3) Go to checkout");
                Console.WriteLine("8) Go to warehouse");
                Console.WriteLine("9) Leave store");
                Console.Write("What do you want to do? ");
                string input = Console.ReadKey().KeyChar.ToString();
                try
                {
                    int numput = Int32.Parse(input);
                    switch (numput)
                    {
                        case 1:
                            StoreInventory();
                            break;
                        case 2:
                            break;
                        case 3:
                            CheckOut();
                            break;
                        case 4:
                            break;
                        case 8:
                            AddWares();
                            break;
                        case 9:
                            inMainMenu = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please choose a valid number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Helplink: "+ex.HelpLink);
                    Console.WriteLine("Message: "+ex.Message);
                    Console.WriteLine("Source: "+ex.Source);
                    Console.WriteLine("Stacktrace: "+ex.StackTrace);
                    Console.WriteLine("Targetsite: "+ex.TargetSite);
                }
            } while (inMainMenu);
        }
    }
}
