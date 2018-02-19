using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateAss
{
    public class CupCoffee : CoffeeDispenser
    {
        public CupCoffee()
        {
            // I know this is wrong - just for ease of use
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "" + BoilWater() + " " + Pour() + " " + Brew() + " Your coffee is ready";
        }
        protected override string Brew()
        {
            return "Coffee is being brewed...";
        }
    }
}
