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
        public event EventHandler StateChanged;

        public int Happiness { get => happiness; set => happiness = value; }
        public int Fatigue { get => fatigue; set => fatigue = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public IState CurrentState { get => currentState; private set => currentState = value; }
        public IState HungryState { get => hungryState; private set => hungryState = value; }
        public IState SleepyState { get => sleepyState; private set => sleepyState = value; }
        public IState MoodState { get => moodState; private set => moodState = value; }
        public bool Sleeping { get => sleeping; set => sleeping = value; }

        public Hero()
        {
            // Create states
            hungryState = new HungryState(this);
            SleepyState = new SleepyState(this);

            ChangeState(hungryState);

        }


        public void ChangeState(IState state)
        {
            CurrentState = state;
            OnStateChanged();
            //Debug.WriteLine("I am changing state");
        }

        public void OnValueChanged(EventArgs ea)
        {
            ValueEventArgs vea = (ValueEventArgs)ea;
            if (vea.State != null)
            {
                if (vea.State is HungryState)
                {
                    //Debug.WriteLine("Hunger value = " + vea.Value);
                    Hunger = vea.Value;
                    if (Hunger >= 100)
                    {
                        Hunger = 100;
                    }
                    ValueChanged?.Invoke(this, new ValueEventArgs(HungryState, Hunger));
                }
                if (vea.State is SleepyState)
                {
                    //Debug.WriteLine("Fatigue value = " + vea.Value);
                    Fatigue = vea.Value;
                    if (Fatigue >= 100)
                    {
                        Fatigue = 100;
                    }
                    ValueChanged?.Invoke(this, new ValueEventArgs(SleepyState, Fatigue));
                }
            }
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

        public void OnStateChanged()
        {
            StateChanged?.Invoke(this, new StateEventArgs(CurrentState.ToString()));
        }
    }
}
