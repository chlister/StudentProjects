using CustomControl.Input;
using System;

namespace CustomControl.Event
{
    public class PotEventArgs : EventArgs
    {
        public PotState State { get; set; }
        public PotEventArgs(PotState state)
        {
            State = state;
        }
    }
}
