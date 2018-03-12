using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_HeltIFisk.Model
{
    public /*abstract */ class Animal
    {
        public string Name { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }

        public Animal(string _name, float _len, float _weight)
        {
            Name = _name;
            Length = _len;
            Weight = _weight;
        }
    }
}
