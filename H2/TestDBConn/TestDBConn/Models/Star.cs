using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;

namespace KroellOgCamrIRummet.Models
{
    public class Star
    {
        private float perimeter;
        private string name;
        private double temperature;

        public float Perimeter { get { return perimeter; }  set { perimeter = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Temperature { get { return temperature; } set { temperature = value; } }

        public Star(float _perimeter, string _name, double _temp)
        {
            Name = _name;
            Temperature = _temp;
            Perimeter = _perimeter;
        }
        public Star()
        {

        }
    }
}
