using H2_ProgrammingTest.Features;
using H2_ProgrammingTest.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H2_ProgrammingTest
{
    /// <summary>
    /// Used for the GUI for the Automat
    /// </summary>
    public class AutomatHandler : Automat
    {
        // Person for given the items when generated. + to check coin
        public AutomatHandler() : base()
        {
            // Would init person here 
        }
        /// <summary>
        /// Start menu
        /// </summary>
        public void StartMenu()
        {
            bool AtMachine = true;
            while (true)
            {
                Console.Clear();
                ShowScreen();
                Console.WriteLine("1) Buy menu");
                Console.WriteLine("2) Input coin");
                Console.WriteLine("3) Retrieve coin");
                Console.Write("Choose a Menu: ");
                try
                {
                    int userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            State = 1;
                            ShowStock();
                            break;
                        case 2:
                            InputCoin();
                            break;
                        case 3:
                            RetriveCoin();
                            break;
                        case 4:
                            Console.WriteLine("You leave the machine...");
                            Thread.Sleep(200);
                            AtMachine = false;
                            break;
                    }

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please input a menu choice");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a valid choice");
                    Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("We were unable to handle you input. Please try again.");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }

        }
        /// <summary>
        /// Input coin menu
        /// </summary>
        private void InputCoin()
        {
            bool coinMenu = true;
            string userInput;
            int coinInp = 0;
            do
            {
                try
                {
                    Console.WriteLine("How much coin would you like to input?");
                    Console.WriteLine("Press Q to leave");
                    Console.WriteLine($"Current coin: {CurrentCoin}");
                    Console.Write("Choose an amount: ");
                    userInput = Console.ReadLine();
                    if (userInput == "q" || userInput == "Q")
                    {
                        coinMenu = false;
                    }
                    else
                    {
                        coinInp = int.Parse(userInput);
                        InputCoin(coinInp);
                        Console.Clear();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input a valid amount");
                    Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please input a valid amount");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    throw e;
                }
            } while (coinMenu);
        }
        /// <summary>
        /// Showing the stock
        /// </summary>
        private void ShowStock()
        {
            bool buyMenu = true;
            do
            {
                string userInput;
                int inputInt;
                int stocknum = 1;
                try
                {
                    Console.WriteLine("Vendor machine 3000: Stock Menu");
                    foreach (Item item in Items)
                    {
                        Console.WriteLine($"{stocknum}) {item.Name}, Price: {item.Price}");
                        stocknum++;
                    }
                    if (Items.Count == 0)
                    {
                        Console.WriteLine("The stock is empty - Returning to main menu");
                        buyMenu = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Choose an item to buy or leave by pressing 'Q'");
                        userInput = Console.ReadLine();
                        if (userInput == "q" || userInput == "Q")
                        {
                            buyMenu = false;
                        }
                        else
                        {
                            Item item;
                            inputInt = int.Parse(userInput);
                            item = Shop(inputInt - 1);
                            Console.WriteLine($"You've bought {item.Name}");
                            Thread.Sleep(200);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("You didn't choose a valid item, or you didn't have enough coin");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    throw e;
                }
            } while (buyMenu);

        }
        /// <summary>
        /// Default screen showing info
        /// </summary>
        private void ShowScreen()
        {
            Console.WriteLine("Vendor Machine 3000");
            Console.WriteLine($"Current coin: {CurrentCoin}");
            Console.WriteLine($"Items in stock: {Items.Count}");
            if (Items.Count == 0)
            {
                Console.WriteLine("Stock is empty. Please wait for inventory to be refilled.");
            }
        }
    }
}
