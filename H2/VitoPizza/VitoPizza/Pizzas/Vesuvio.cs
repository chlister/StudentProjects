using System;
using System.Collections.Generic;
using System.Text;
using VitoPizza.Ingredients;

namespace VitoPizza.Pizzas
{
    /// <summary>
    /// 
    /// </summary>
    class Vesuvio : Pizza, ICheese, IEgg, IBasil
    {

        public string Basil { get; set; } = "Basil";
        public string Cheese { get; set; } = "Cheese";
        public string Egg { get; set; } = "Egg";

        /// <summary>
        /// 
        /// </summary>
        public Vesuvio()
        {

        }
        public override string ToString()
        {
            return $" {Cheese}, {Egg}, {Basil}";
        }
    }
}
