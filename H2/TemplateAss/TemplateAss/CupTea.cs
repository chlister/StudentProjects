using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateAss
{
    class CupTea : CoffeeDispenser
    {
        public CupTea() : base()
        {
            // I know this is wrong - just for ease of use
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "" + BoilWater() + " " + Pour() + " " + Brew() + " Your tea is ready";
        }

        protected override string Brew()
        {
            return "Tea is being brewed...";
        }
    }
}
