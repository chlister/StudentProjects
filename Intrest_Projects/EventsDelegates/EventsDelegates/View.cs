using EventsDelegates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    class View : IObserver
    {
        private int foodNeed;
        private int sleepNeed;
        private Hero myHero;
        public int FoodNeed { get => foodNeed; set => foodNeed = value; }
        public int SleepNeed { get => sleepNeed; set => sleepNeed = value; }

        public View(Hero _myHero)
        {
            myHero = _myHero;
        }

        public void StatScreen()
        {
            Console.WriteLine(FoodNeed);
            Console.WriteLine(SleepNeed);
        }
    }
}
