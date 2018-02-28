using H2_ProgrammingTest.Features;
using H2_ProgrammingTest.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_ProgrammingTest
{
    public abstract class Automat : IStock, IShop, ICoinHandle
    {
        protected enum States { Ready = 1, InUse, Empty}
        public int State { get; set; }
        public List<Item> Items { get; private set; }
        public int CurrentCoin { get; private set; }
        public int StockedCoin { get; private set; }

        /// <summary>
        /// Creating the Automat, it's empty by default
        /// </summary>
        public Automat()
        {
            Items = new List<Item>
            {
                new Cola()
            };
        }
        /// <summary>
        /// Used for filling the stock
        /// </summary>
        /// <param name="item"></param>
        public void FillStock(Item item)
        {
            try
            {
                Items.Add(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Used for shopping
        /// </summary>
        /// <param name="_userInput"></param>
        /// <returns></returns>
        public Item Shop(int _userInput)
        {
            try
            {
                if (_userInput > Items.Count)
                {
                    return null;
                }
                else if (CurrentCoin < Items[_userInput].Price)
                {
                    return null;
                }
                else
                {
                    StockedCoin += CurrentCoin;
                    CurrentCoin -= Items[_userInput].Price;
                    Items.Remove(Items[_userInput]);
                    return Items[_userInput];
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        /// <summary>
        /// Used for input of coin
        /// </summary>
        /// <param name="coin"></param>
        public void InputCoin(int coin)
        {
            CurrentCoin += coin;
        }
        /// <summary>
        /// Used for getting your coin back
        /// </summary>
        /// <returns></returns>
        public int RetriveCoin()
        {
            int outputCoin = CurrentCoin;
            CurrentCoin = 0;

            return outputCoin;
        }
    }
}
