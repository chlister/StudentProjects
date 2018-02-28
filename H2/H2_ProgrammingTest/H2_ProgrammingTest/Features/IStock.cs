using H2_ProgrammingTest.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_ProgrammingTest.Features
{
    interface IStock
    {
        List<Item> Items { get; }
        void FillStock(Item item);
    }
}
