using CustomControl.Input;
using System;

namespace CustomControl.Event
{
    public    class DirectionEventArgs : EventArgs
    {
        public Directions Direction { get; set; }
        public DirectionEventArgs(Directions dir)
        {
            Direction = dir;
        }
    }
}
