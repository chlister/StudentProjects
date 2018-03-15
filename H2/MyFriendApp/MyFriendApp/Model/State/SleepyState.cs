using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model.State
{
    internal class SleepyState : HeroState
    {
        public SleepyState(IHero _heroState) : base(_heroState)
        {

        }

        protected override async void Live()
        {
            while (true)
            {
                Debug.WriteLine("step 1: Hero Fatigue = " + Hero.Fatigue + " Hero asleep? "+ Hero.Sleeping);
                if (Hero.Sleeping == false)
                {
                    Debug.WriteLine("I am getting sleepy");
                    if (Hero.Fatigue > 0)
                    {
                        Hero.Fatigue--;
                    }
                    if (Hero.Fatigue == 0)
                    {
                        Debug.WriteLine("I Fell asleep");
                        Hero.Sleeping = true;
                        Hero.ChangeState(Hero.SleepyState);
                    }

                }
                else
                {
                    if (Hero.Fatigue < 100)
                    {
                        Debug.WriteLine("Going to sleep");
                        Hero.Fatigue += 10;
                    }
                    else
                    {
                        Debug.WriteLine("I have woken");
                        Hero.Sleeping = false;
                        Hero.ChangeState(Hero.HungryState);
                    }
                }
                Hero.OnValueChanged(new ValueEventArgs(this, Hero.Fatigue));
                await Task.Delay(TimeSpan.FromSeconds(1));

            }
        }
        public override string ToString()
        {
            return "sleepy state";
        }

        public override void Feed()
        {
            Debug.WriteLine("I am sleeping!");
        }

        public override void Sleep()
        {
            Debug.WriteLine("I am already asleep!");
        }

        public override void TalkTo()
        {
            Debug.WriteLine("Shhhh i am sleeping");
        }
    }
}
