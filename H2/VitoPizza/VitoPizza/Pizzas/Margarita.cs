using System;
using System.Collections.Generic;
using System.Text;
using VitoPizza.Ingredients;

namespace VitoPizza.Pizzas
{
    class Margarita : Pizza, ICheese, IOregano
    {
        public string Cheese { get; set; } = "Cheese";
        public string Oregano { get; set; } = "Oregano";

        public Margarita()
        {

        }
        public override string ToString()
        {
            return $" {Cheese}, {Oregano}";
        }
    }
}
