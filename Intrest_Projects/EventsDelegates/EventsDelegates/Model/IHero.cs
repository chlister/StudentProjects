using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates.Model
{
    interface IHero
    {
        int FoodNeed { get; set; }
        int SleepNeed { get; set; }
        void Feed(int food);
        void Sleep();
    }
}
