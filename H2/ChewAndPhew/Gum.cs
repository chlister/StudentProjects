using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewAndPhew
{
    class Gum
    {
        public string Color { get; set; }
        public string Taste { get; set; }

        public Gum(string _taste, string _color)
        {
            Taste = _taste;
            Color = _color;
        }
        public override string ToString()
        {
            try
            {
                return $"Hey the Gum is {Color} and tastes like {Taste}";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
