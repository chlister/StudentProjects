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
        public HeroState(IHero _heroState)
        {
            hero = _heroState;
            //create the simple life of a hero
            Task task = new Task(delegate { Live(); });
            task.Start();
        }
        public void Feed()
        {
            Debug.WriteLine("I am being fed");
        }

        public void Sleep()
        {
            Debug.WriteLine("I am sleeping");
        }

        public void TalkTo()
        {
            Debug.WriteLine("I am being talked to");
        }
        protected abstract void Live();
        public abstract override string ToString();
    }
}
