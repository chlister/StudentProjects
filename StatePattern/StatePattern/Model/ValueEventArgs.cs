using StatePattern.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model
{
    public class ValueEventArgs : EventArgs
    {
        public IState State { get => state; set => state = value; }
        public int Value { get => value; set => this.value = value; }

        IState state; int value;
        public ValueEventArgs(IState state, int value)
        {
            State = state;
            Value = value;
        }

    }
}
