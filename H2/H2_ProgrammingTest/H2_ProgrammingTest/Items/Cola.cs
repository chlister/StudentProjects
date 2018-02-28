using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_ProgrammingTest.Items
{
    public class Cola : Item
    {
        public override string Name { get; set; } = "Cola";
        public override int Price { get; set; } = 15;

        public Cola()
        {

        }
        
    }
}
