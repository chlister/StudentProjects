using System;
using VitoPizza.Pizzas;

namespace VitoPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(new PizzaFactory().CreatePizza().ToString());
               
            }
            Console.ReadLine();
        }
    }
}
