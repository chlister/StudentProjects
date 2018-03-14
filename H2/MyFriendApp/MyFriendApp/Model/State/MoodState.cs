using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model.State
{
    internal class MoodState : HeroState
    {
        private int happiness = 100;
        public MoodState(IHero _heroState) : base(_heroState)
        {

        }

        protected override async void Live()
        {
            while (true)
            {
                if (happiness > 0)
                {

                    Debug.WriteLine("I am happy");
                    await Task.Delay(TimeSpan.FromSeconds(10));

                }
                else
                {
                    // I am sad?
                    Debug.WriteLine("Make me heppy!");
                    await Task.Delay(TimeSpan.FromSeconds(10));
                }
            }
        }
        public override string ToString()
        {
            return "happy state";
        }
    }
}
