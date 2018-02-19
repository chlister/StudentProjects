using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VitoPizza.Pizzas
{
    class PizzaFactory
    {
        Random rnd = new Random();
        public Pizza CreatePizza()
        {
            Thread.Sleep(200);
            int p = rnd.Next(1,3);
            switch (p)
            {
                case 1:
                    return new Vesuvio();
                case 2:
                    return new Margarita();
                case 3:
                    return new AnchovyP();
                default:
                    return null;
            }
        }
    }
}
