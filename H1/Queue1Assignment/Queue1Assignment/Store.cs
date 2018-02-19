using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1Assignment
{
    class Store
    {
        
        public Store()
        {

        }
        public List<Meat> meats = new List<Meat>();
        public List<Beverage> beverages = new List<Beverage>();
        public List<Fruit> fruits = new List<Fruit>();
        public void CreateNewFruit(string _name, int _price)
        {
            Fruit fruit = new Fruit(_name, _price);
            fruits.Add(fruit);
        }
        public void CreateNewMeat(string _name, int _price)
        {
            Meat meat = new Meat(_name, _price);
            meats.Add(meat);
        }
        public void CreateNewBeverage(string _name, int _price)
        {
            Beverage beverage = new Beverage(_name, _price);
            beverages.Add(beverage);
        }
        public void PrintWares(string _input)
        {
            if (_input == "Fruit" || _input == "1")
            {
                foreach (Fruit fruit in fruits)
                {
                    Console.WriteLine("Name: {0}\r\nPrice {1:C}\r\nProduction Date: {2:MM/dd/yy}\r\n", fruit.Name, fruit.Price, fruit.ProdDate);
                }
            }
            else if (_input == "Meat" || _input == "2")
            {
                foreach (var meat in meats)
                {
                    Console.WriteLine("Name: {0}\r\nPrice {1:C}\r\nProduction Date: {2:MM/dd/yy}\r\n", meat.Name, meat.Price, meat.ProdDate);
                }
            }
            else if (_input == "Beverage" || _input == "3")
            {
                foreach (var beverages in beverages)
                {
                    Console.WriteLine("Name: {0}\r\nPrice {1:C}\r\nProduction Date: {2:MM/dd/yy}\r\n", beverages.Name, beverages.Price, beverages.ProdDate);
                }
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            
        }

    }
}
