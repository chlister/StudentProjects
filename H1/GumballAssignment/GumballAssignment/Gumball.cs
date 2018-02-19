using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballAssignment
{
    class Gumball
    {
        #region Fields
        private string color;
        private string taste;
        #endregion
        #region Properties
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }
        #endregion
        public Gumball()
        {

        }
        public Gumball(string _color)
        {
            Color = _color;
            switch (_color)
            {
                case "Green":
                    Taste = "Apple";
                    break;
                case "Blue":
                    Taste = "Blueberry";
                    break;
                case "Purple":
                    Taste = "Blackberry";
                    break;
                case "Yellow":
                    Taste = "TuttiFrutti";
                    break;
                case "Orange":
                    Taste = "Orange";
                    break;
                case "Red":
                    Taste = "Strawberry";
                    break;
            }
        }

    }
}
