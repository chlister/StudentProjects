using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatAssignment
{
    class Product
    {
        #region Fields
        private string name;
        private int cost;
        #endregion
        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        #endregion
        public Product(string _name, int _cost) : this()
        {
            Name = _name;
            Cost = _cost;
        }

        public Product()
        {
        }
    }
}
