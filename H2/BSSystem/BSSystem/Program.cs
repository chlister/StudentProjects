using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSSystem.Models;
using BSSystem.Utils;

namespace BSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Desk d1 = new Desk("Desk_1");
            d1.HandleBag(new Bagage("London"));
            Console.ReadLine();
        }
    }
}
