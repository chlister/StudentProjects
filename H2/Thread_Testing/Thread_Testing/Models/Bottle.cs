using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Testing.Models
{
    class Bottle
    {
        public int ReturnPrice { get; set; }
        public string BottleType { get; set; }
        public enum typeOfBott { Water, Beer, Soda }
        public Bottle(string _bottleType)
        {
        }
    }
}
