using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChewAndPhew
{
    class GumMachine
    {
        private static GumMachine instance;
        private static int maxGums = 55; // The max number of Gums in the machine
        // All these values represent the number og gums in the machine
        private int blues = Convert.ToInt16(maxGums * 0.25);
        private int reds = Convert.ToInt16(maxGums * 0.14);
        private int yellows = Convert.ToInt16(maxGums * 0.20);
        private int oranges = Convert.ToInt16(maxGums * 0.19) - 1;
        private int purples = Convert.ToInt16(maxGums * 0.12);
        private int greens = Convert.ToInt16(maxGums * 0.10);
        // List of gums for the Machine
        public List<Gum> Gums { get; set; }
        // Singleton "Constructor" if the instance doesn't exist the instance is created
        public static GumMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GumMachine();
                }
                return instance;
            }
        }

        private GumMachine()
        {
            // List is instantiated
            Gums = new List<Gum>();
            // Fill Machine with the gums
            FillMachine();
        }

        /// <summary>
        /// Method filling the machine with gums
        /// </summary>
        private void FillMachine()
        {
            try
            {
                FillMachineWithGum(blues, "Blueberry", "Blue");
                FillMachineWithGum(reds, "Strawberry", "Red");
                FillMachineWithGum(yellows, "Lime", "Yellow");
                FillMachineWithGum(oranges, "Orange", "Orange");
                FillMachineWithGum(purples, "Aubergine", "Purple");
                FillMachineWithGum(greens, "Booger", "Green");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method fills the List<Gum> 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="taste"></param>
        /// <param name="color"></param>
        private void FillMachineWithGum(int num, string taste, string color)
        {
            for (int i = 0; i < num; i++)
            {
                Gums.Add(new Gum(taste, color));
            }
        }


        /// <summary>
        /// Method that returns a random Gum from the Machine an removes it from the list
        /// </summary>
        /// <returns></returns>
        public Gum GetGum()
        {
            Random rnd = new Random();
            Thread.Sleep(100);
            try
            {
                int rndNum = rnd.Next(0, Gums.Count);
                Gum gum = Gums[rndNum];
                Gums.Remove(Gums[rndNum]);
                return gum;
            }
            catch (Exception)
            {
                Console.WriteLine("No more gums in the machine");
                return null;
            }
        }
        /// <summary>
        /// Method for refilling th gum machine
        /// </summary>
        /// <returns>string</returns>
        public string Refillmachine()
        {
            try
            {
                if (Gums.Count != 0)
                {
                    return "You can't fill the machine if it's not empty";
                }
                else
                {
                    FillMachine();
                    return "You filled the machine with Gums from your pockets!";
                }
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
    }
}
