using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Testing.Models
{
    class ProductFactory
    {
        public ProductFactory()
        {

        }
        public Product CreateProduct(string _prodType)
        {
            switch (_prodType)
            {
                case "Beer":
                    return new Beer("Tuborg", 20);
                case "Soda":
                    return new Soda("Cola", 15);
                default:
                    return null;
            }
        }
    }
}
