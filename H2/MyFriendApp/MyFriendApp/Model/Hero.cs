using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFriendApp.Model.State;

namespace MyFriendApp.Model
{
    class Hero : IHero, IState
    {
        private IState currentState, hungryState, sleepyState, moodState;
        private int happiness, fatigue, hunger = 100;
        private bool sleeping;
        public event EventHandler ValueChanged;
        public int Happiness { get => happiness; set => happiness = value; }
        public int Fatigue { get => fatigue; set => fatigue = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public IState CurrentState { get => currentState; set => currentState = value; }
        public IState HungryState { get => hungryState; set => hungryState = value; }
        public IState SleepyState { get => sleepyState; set => sleepyState = value; }
        public IState MoodState { get => moodState; set => moodState = value; }
        public bool Sleeping { get => sleeping; set => sleeping = value; }

        public Hero()
        {
            // Create states
            hungryState = new HungryState(this);
            SleepyState = new SleepyState(this);

            currentState = hungryState;

        }


        public void ChangeState(IState state)
        {
            CurrentState = state;

            Debug.WriteLine("I am changing state");
        }

        public void OnValueChanged(EventArgs ea)
        {
            ValueChanged?.Invoke(this, ea);
        }

        public void Feed()
        {
            CurrentState.Feed();
        }

        public void Sleep()
        {
            CurrentState.Sleep();
        }

        public void TalkTo()
        {
            throw new NotImplementedException();
        }
    }
}
