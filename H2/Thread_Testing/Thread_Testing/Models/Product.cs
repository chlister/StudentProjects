using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Testing.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public abstract string ProdType { get; set; }
    }
}
