using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDelegates.Model
{
    class Hero : IHero, IObservable
    {
        private int foodNeed, sleepNeed = 100;
        public int FoodNeed
        {
            get => foodNeed; set
            {
                foodNeed = value;
                if (foodNeed > 100)
                {
                    foodNeed = 100;
                }
            }
        }
        public int SleepNeed
        {
            get => sleepNeed;
            set
            {
                sleepNeed = value;
                if (sleepNeed > 100)
                {
                    sleepNeed = 100;
                }
            }
        }
        public Hero()
        {

        }

        public event EventHandler ValueChanged;
        public delegate void MyEventHandler(object sender, EventArgs e);
        /// <summary>
        /// Raises event without Delegate
        /// </summary>
        /// <param name="food"></param>
        public void Feed(int food)
        {
            FoodNeed += food;
            ValueChanged?.Invoke(this, new EventArgs());
        }
        /// <summary>
        /// Raises event with Delegate
        /// </summary>
        public void Sleep()
        {
            int time = 100 - SleepNeed;
            for (int i = 0; i < time; i++)
            {
                Thread.Sleep(50);
            }
            SleepNeed = 100;
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
