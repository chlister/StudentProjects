using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model.State
{
    internal class HungryState : HeroState
    {
        public HungryState(IHero partner) : base(partner)
        {
        }

        public override string ToString()
        {
            return "hungry state";
        }

        protected override async void Live()
        {
            while (true)
            {
                if (Hero.Hunger > 0)
                {
                    Hero.Hunger = Hero.Hunger - 2;
                    
                    Hero.OnValueChanged(new ValueEventArgs(this, Hero.Hunger));

                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
        public override void Feed()
        {
            Hero.Hunger = Hero.Hunger + 10;
            Hero.OnValueChanged(new ValueEventArgs(this, Hero.Hunger));
        }

        public override void Sleep()
        {
            Debug.WriteLine("Going to sleep");
            Hero.Sleeping = true;
            Hero.ChangeState(Hero.SleepyState);
        }

        public override void TalkTo()
        {
            throw new NotImplementedException();
        }
    }
}
