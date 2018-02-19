using System;
using System.Collections.Generic;
using System.Text;
using VitoPizza.Ingredients;

namespace VitoPizza.Pizzas
{
    /// <summary>
    /// Internal class because it wouldn't make sense that the ingredients knew how to make pizza
    /// </summary>
    internal abstract class Pizza : IDough, ITomato
    {
        public string Dough { get; set; } = "Dough";
        public string Tomato { get; set; } = "Tomat";
        public override string ToString()
        {
            return $"Pizza is made of : {Dough}, {Tomato}";
        }
    }

    
}
