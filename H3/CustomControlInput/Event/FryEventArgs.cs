using CustomControl.Input;
using System;

namespace CustomControl.Event
{
    public    class FryEventArgs : EventArgs
    {
        public FryState State { get; set; }
        public FryEventArgs(FryState state)
        {
            State = state;
        }
    }
}
