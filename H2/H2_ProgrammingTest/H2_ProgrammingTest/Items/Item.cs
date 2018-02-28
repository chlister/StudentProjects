using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_ProgrammingTest.Items
{
    public abstract class Item
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public Item()
        {

        }
    }
}
