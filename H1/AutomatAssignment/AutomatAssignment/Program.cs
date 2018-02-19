using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAssignment
{
    class Program
    {
        public static Automat automat = new Automat();
        public static int wallet;
        static void Main(string[] args)
        {
            // Wallet is a placeholder. doesn't matter how much cash he has.
            wallet = 100;
            MainGUI();
            Console.ReadLine();
        }
        public static void MainGUI()
        {
            bool menu = true;
            do
            {
                Console.Clear();
                string input;
                Console.WriteLine("Captn Auto!");
                Console.WriteLine("1) See products");
                Console.WriteLine("2) Refill products");
                Console.WriteLine("3) Put in coins");
                Console.WriteLine("4) Exit menu");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ProductGUI();
                        break;
                    case "2":
                        RefillGUI();
                        break;
                    case "3":
                        CoinGUI();
                        break;
                    case "4":
                        menu = false;
                        break;
                    default:
                        break;
                }
            } while (menu);
            
        }
        static void ProductGUI()
        {
            bool productMenu = true;
            do
            {
                Console.Clear();
                int choice;
                Console.WriteLine("Inventory screen");
                Console.WriteLine("Current inserted coins: {0}", automat.InsertedCoin);
                Console.WriteLine("Choose an item to buy");
                Console.WriteLine("1) Cola, Price: {0}", automat.SeeProducts(1).Cost);
                Console.WriteLine("2) Chips, Price: {0}", automat.SeeProducts(2).Cost);
                Console.WriteLine("3) Water, Price: {0}", automat.SeeProducts(3).Cost);
                Console.WriteLine("4) M&Ms, Price: {0}", automat.SeeProducts(4).Cost);
                Console.WriteLine("5) Pringels, Price: {0}", automat.SeeProducts(5).Cost);
                Console.WriteLine("9) Exit menu");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You got {0}", automat.RetriveProduct(choice));
                        break;
                    case 2:
                        Console.WriteLine("You got {0}", automat.RetriveProduct(choice));
                        break;
                    case 3:
                        Console.WriteLine("You got {0}", automat.RetriveProduct(choice));
                        break;
                    case 4:
                        Console.WriteLine("You got {0}", automat.RetriveProduct(choice));
                        break;
                    case 5:
                        Console.WriteLine("You got {0}", automat.RetriveProduct(choice));
                        break;
                    case 9:
                        productMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid input");
                        break;
                }
                Console.ReadLine();
            } while (productMenu);
            
        }
        static void RefillGUI()
        {
            bool refillMenu = true;
            do
            {
                Console.Clear();
                string refillInput;
                Console.WriteLine("Stock inventory");
                Console.WriteLine("Choose an item to stock");
                Console.WriteLine("1) Cola");
                Console.WriteLine("2) Chips");
                Console.WriteLine("3) Water");
                Console.WriteLine("4) M&Ms");
                Console.WriteLine("5) Pringels");
                Console.WriteLine("9) Exit menu");
                refillInput = Console.ReadLine();
                switch (refillInput)
                {
                    case "1":
                        automat.RefillProduct(1);
                        break;
                    case "2":
                        automat.RefillProduct(2);
                        break;
                    case "3":
                        automat.RefillProduct(3);
                        break;
                    case "4":
                        automat.RefillProduct(4);
                        break;
                    case "5":
                        automat.RefillProduct(5);
                        break;
                    case "9":
                        refillMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
                Console.ReadLine();
            } while (refillMenu);
            
        }
        /**
         * Doesn't work properly
         * */
        static void CoinGUI()
        {
            bool coinMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Put in your coins");
                Console.WriteLine("Current coins stored: {0}", automat.InsertedCoin);
                Console.WriteLine("Choose coin");
                Console.WriteLine("9) Exit menu");
                if (wallet > 0)
                {
                    Console.WriteLine("1 kr.");
                    if (wallet >= 2)
                    {
                        Console.WriteLine("2 kr.");
                        if (wallet >= 5)
                        {
                            Console.WriteLine("5 kr.");
                            if (wallet >= 10)
                            {
                                Console.WriteLine("10 kr.");
                                if (wallet >= 20)
                                {
                                    Console.WriteLine("20 kr.");
                                }
                            }
                        }
                    }
                }
                int coin = int.Parse(Console.ReadLine());
                switch (coin)
                {
                    case 1:
                        if (wallet == 0)
                        {
                            Console.WriteLine("You have no money left");
                        }
                        else
                        {
                            Console.WriteLine("Inserted {0:C}", coin);
                            wallet -= coin;
                            automat.CountCoins(coin);
                        }
                        
                        break;
                    case 2:
                        if (wallet < 2)
                        {
                            Console.WriteLine("You have no more of these coins");
                        }
                        else
                        {
                            Console.WriteLine("Inserted {0:C}", coin);
                            wallet -= coin;
                            automat.CountCoins(coin);
                        }
                        
                        break;
                    case 5:
                        if (wallet < 5)
                        {
                            Console.WriteLine("You have no more of these coins");
                        }
                        else
                        {
                            Console.WriteLine("Inserted {0:C}", coin);
                            wallet -= coin;
                            automat.CountCoins(coin);
                        }
                        break;
                    case 10:
                        if (wallet < 10)
                        {
                            Console.WriteLine("You have no more of these coins");
                        }
                        else
                        {
                            Console.WriteLine("Inserted {0:C}", coin);
                            wallet -= coin;
                            automat.CountCoins(coin);
                        }
                        break;
                    case 20:
                        if (wallet < 20)
                        {
                            Console.WriteLine("You have no more of these coins");
                        }
                        else
                        {
                            Console.WriteLine("Inserted {0:C}", coin);
                            wallet -= coin;
                            automat.CountCoins(coin);
                        }
                        break;
                    case 9:
                        coinMenu = false;
                        break;
                    default:
                        Console.WriteLine("Insert a valid coin");
                        break;
                }
                Console.ReadLine();
                

            } while (coinMenu);
            
        }
    }
}
