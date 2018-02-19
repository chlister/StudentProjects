using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1Assignment
{
    class Fruit
    {
        #region Fields
        private string name;
        private DateTime prodDate;
        private bool isFresh;
        private int price;
        #endregion
        #region Props
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime ProdDate
        {
            get { return prodDate; }
            set { prodDate = value; }
        }
        public bool IsFresh
        {
            get { return isFresh; }
            set { isFresh = value; }
        }
        #endregion

        public Fruit()
        {

        }
        public Fruit(string _name, int _price)
        {
            Name = _name;
            ProdDate = DateTime.Now;
            Price = _price;
        }

    }
}
