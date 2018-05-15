using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model.State
{
    public abstract class State : IState
    {
        // The states has to be able to interact with the Hero
        IHero hero;
        public IHero Hero { get => hero; set => hero = value; }
        /// <summary>
        /// Constructs the state of a hero
        /// </summary>
        /// <param name="hero"></param>
        public State(IHero hero)
        {
            Hero = hero;
            Task task = new Task(delegate { Live(); });
            task.Start();
        }
        /**
         * Abstract Live method - Runs async on all methods
         * */
        public abstract void Live();
        /**
         * Methods to be used for interaction between the states
         * */
        public void BattleVillain()
        {
            Debug.WriteLine("I am going to battle!");
        }

        public void Eat()
        {
            Debug.WriteLine("I am going to eat!");
        }

        public void SaveTheDay()
        {
            Debug.WriteLine("I am going to save the day!");
        }

        public void Sleep()
        {
            Debug.WriteLine("I am going to sleep!");
        }
    }
}
