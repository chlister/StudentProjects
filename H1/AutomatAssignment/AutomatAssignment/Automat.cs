using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAssignment
{
    class Automat
    {
        //A way to store a collection of only one product a.i. Cola/Chips/Water - has a fixed number of items (15)
        //Could be a stack / queue - We have no need of iterating through the list or removing the middle one.
        // Design lavet af Tango automaten - Valgt at sige hver række er min stack så jeg ikke laver alt for mange collections
        Stack<Product> colas = new Stack<Product>();
        Stack<Product> chips = new Stack<Product>();
        Stack<Product> water = new Stack<Product>();
        Stack<Product> mnms = new Stack<Product>();
        Stack<Product> pringels = new Stack<Product>();
        #region Field
        private int insertedCoin;
        #endregion
        #region Properties
        public int InsertedCoin
        {
            get { return insertedCoin; }
            private set { insertedCoin = value; }
        }
        #endregion

        /**
         * When initializing the Automat. Add all the products 
         * (We got a great deal, when buying the machine, we got a free refill ;) )
         * */
        public Automat()
        {
            for (int i = 0; i < 15; i++)
            {
                colas.Push(new Product("Cola", 20));
                chips.Push(new Product("Chips", 15));
                water.Push(new Product("Water", 10));
                mnms.Push(new Product("M&Ms", 25));
                pringels.Push(new Product("Pringels", 15));
            }
        }
        public string RetriveProduct(int choice)
        {
            switch (choice)
            {
                case 1:
                    if (insertedCoin >= colas.Peek().Cost)
                    {
                        insertedCoin -= colas.Peek().Cost;
                        return colas.Pop().Name;
                    }
                    break;
                case 2:
                    if (insertedCoin >= chips.Peek().Cost)
                    {
                        insertedCoin -= chips.Peek().Cost;
                        return chips.Pop().Name;
                    }
                    break;
                case 3:
                    if (insertedCoin >= water.Peek().Cost)
                    {
                        insertedCoin -= water.Peek().Cost;
                        return water.Pop().Name;
                    }
                    break;
                case 4:
                    if (insertedCoin >= mnms.Peek().Cost)
                    {
                        insertedCoin -= mnms.Peek().Cost;
                        return mnms.Pop().Name;
                    }
                    break;
                case 5:
                    if (insertedCoin >= pringels.Peek().Cost)
                    {
                        insertedCoin -= pringels.Peek().Cost;
                        return pringels.Pop().Name;
                    }
                    break;
            }
            return "not enough coins. Input coins";
        }
        public Product SeeProducts(int choice)
        {
            switch (choice)
            {
                case 1:
                    return colas.Peek();
                    //break;
                case 2:
                    return chips.Peek();
                    //break;
                case 3:
                    return water.Peek();
                    //break;
                case 4:
                    return mnms.Peek();
                    //break;
                case 5:
                    return pringels.Peek();
                    //break;
            }
            return null;
        }
        public void RefillProduct(int choice)
        {
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < MissingProduct(colas); i++)
                    {
                        colas.Push(new Product("Cola", 20));
                    }
                    break;
                case 2:
                    for (int i = 0; i < MissingProduct(chips); i++)
                    {
                        chips.Push(new Product("Chips", 15));
                    }
                    break;
                case 3:
                    for (int i = 0; i < MissingProduct(water); i++)
                    {
                        water.Push(new Product("Water", 10));
                    }
                    break;
                case 4:
                    for (int i = 0; i < MissingProduct(mnms); i++)
                    {
                        mnms.Push(new Product("M&Ms", 25));
                    }
                    break;
                case 5:
                    for (int i = 0; i < MissingProduct(pringels); i++)
                    {
                        pringels.Push(new Product("Pringels", 15));
                    }
                    break;
            }
        }
        private int MissingProduct(Stack<Product> stack)
        {
            int missing = 15 - stack.Count();
            return missing;
        }
        public int CountCoins(int coin)
        {
            InsertedCoin += coin;
            return insertedCoin;
        }
    }
}
