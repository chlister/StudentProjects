using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Model.State;

namespace StatePattern.Model
{
    class Hero : IHero
    {
        // Specify all the states to be used
        private IState currentState, hungryState;
        // Generate properties for currentstate
        public IState CurrentState { get => currentState; set => throw new NotImplementedException(); }
        public event EventHandler ValueChanged;

        public Hero()
        {
            // Create the states to be used
            hungryState = new HungryState(this);
        }

        /// <summary>
        /// Used to change the state on Hero
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(IState state)
        {
            currentState = state;
            Debug.WriteLine("State Change");
        }

        /// <summary>
        /// TODO 
        /// </summary>
        /// <param name="ea"></param>
        public void OnValueChanged(EventArgs ea)
        {
            ValueChanged?.Invoke(this, ea);
        }
    }
}
