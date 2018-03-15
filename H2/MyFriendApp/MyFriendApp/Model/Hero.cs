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

        public event EventHandler ValueChanged;
        public Hero()
        {
            // Create states
            hungryState = new HungryState(this);
            sleepyState = new SleepyState(this);

            currentState = hungryState;

        }

        public IState CurrentState { get => currentState; set => currentState = value; }


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
            hungryState.
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void TalkTo()
        {
            throw new NotImplementedException();
        }
    }
}
