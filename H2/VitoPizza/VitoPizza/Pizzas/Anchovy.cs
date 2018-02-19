using System;
using System.Collections.Generic;
using System.Text;
using VitoPizza.Ingredients;

namespace VitoPizza.Pizzas
{
    class AnchovyP : Pizza, ICheese, IRedOnion, IBasil, IAnchovy
    {
        public string Cheese { get; set; } = "Cheese";
        public string RedOnion { get; set; } = "Red Onion";
        public string Basil { get; set; } = "Basil";
        public string Anchovy { get; set; } = "Anchovy";

        public AnchovyP()
        {

        }
        public override string ToString()
        {
            return base.ToString() + $" {Cheese}, {RedOnion}, {Basil}, {Anchovy}";
        }
    }
}
