using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model
{
    public class StateEventArgs : EventArgs
    {
        string state;
        public string State { get => state; set => state = value; }

        public StateEventArgs(string state)
        {
            State = state;
        }

    }
}
