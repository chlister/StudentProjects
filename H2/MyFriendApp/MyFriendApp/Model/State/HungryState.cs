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
        private int hungry = 100;

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
                Debug.WriteLine("Simple life hungry");

                if (hungry > 0)
                {
                    hungry = hungry - 2;

                    //Hero is hungry and we need at state change
                    if (hungry < 90)
                    {
                        Hero.ChangeState(this);
                    }
                    Hero.OnValueChanged(new ValueEventArgs(this, hungry));

                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
