using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model.State
{
    public abstract class HeroState : IState
    {
        IHero hero;
        public IHero Hero { get => hero; set => hero = value; }

        public HeroState(IHero hero)
        {
            this.hero = hero;
            //create the simple life of a hero
            Task task = new Task(delegate { Live(); });
            task.Start();
        }
        public abstract void Feed();

        public abstract void Sleep();

        public abstract void TalkTo();
        protected abstract void Live();
        public abstract override string ToString();
    }
}
