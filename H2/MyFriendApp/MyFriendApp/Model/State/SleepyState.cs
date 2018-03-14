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
        private int sleepiness = 100;
        public SleepyState(IHero _heroState) : base(_heroState)
        {

        }

        protected override async void Live()
        {
            while (true)
            {
                if (true)
                {
                    Debug.WriteLine("I am getting sleepy");
                    await Task.Delay(TimeSpan.FromSeconds(10));
                }
            }
        }
        public override string ToString()
        {
            return "sleepy state";
        }
    }
}
