using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread_Testing.Models;

namespace Thread_Testing
{
    public class VendingMachine
    {
        private List<Product> products;
        private static VendingMachine instance;
        public static VendingMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VendingMachine();
                }
                return instance;
            }
        }
        public object _lock = new object();
        public int RowSize { get; set; } = 15;
        public List<Product> Products
        {
            get { return products; }
            set
            {
                if (TypeCount(value[0].Name) >= RowSize)
                {

                }
                products = value;
            }
        }
        public Queue<Beer> Beers { get; set; }
        public Queue<Soda> Sodas { get; set; }
        private VendingMachine()
        {
            Sodas = new Queue<Soda>(RowSize);
            Beers = new Queue<Beer>(RowSize);
        }
        private int TypeCount(string type)
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item.ProdType.ToUpper() == type.ToUpper())
                {
                    count++;
                }
            }
            return count;
        }

    }
}
