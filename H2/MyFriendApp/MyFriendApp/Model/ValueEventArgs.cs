using MyFriendApp.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model
{
    public class ValueEventArgs : EventArgs
    {

        IState state; int value;
        public ValueEventArgs(IState state, int value)
        {
            State = state;
            Value = value;
        }

        public IState State { get => state; set => state = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
