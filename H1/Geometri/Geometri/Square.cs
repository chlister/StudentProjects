using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private double Sides { get; set; }

        public Square() { 
}
        public Square(double sides)
        {
            this.Sides = sides;
        }

        public double Perimeter()
        {
            double peri;
            peri = Sides * 4;
            return peri;
        }
        public double Area()
        {
            double area;
            area = Sides * Sides;
            return area;
        }
    }
}
