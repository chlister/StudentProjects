using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model.State
{
    public class HungryState : State
    {
        private int hunger = 100;
        /// <summary>
        /// Constructor for hungrystate
        /// </summary>
        /// <param name="hero"></param>
        public HungryState(IHero hero) : base(hero)
        {
        }

        public override async void Live()
        {
            while (true)
            {
                Debug.WriteLine("Getting hungry");
                if (hunger > 0)
                {
                    hunger--;
                    if (hunger < 90)
                    {
                        Debug.WriteLine("I am very hungry!");
                        Hero.ChangeState(this);
                    }
                    Hero.OnValueChanged(new ValueEventArgs(this, hunger));
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
