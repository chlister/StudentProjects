using StatePattern.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model
{
    public interface IHero
    {
        // Dictates the current state the hero is in
        IState CurrentState { get; set; }

        // Used to change the current state
        void ChangeState(IState state);
        // This event is called when values inside Hero changes
        event EventHandler ValueChanged;
        // Used to proclaim a change in state
        void OnValueChanged(EventArgs ea);
    }
}
