using System;

namespace ArduinoOutput
{
    public class DirectionEventArgs : EventArgs
    {
        public Direction Direction { get; }
        public DirectionEventArgs(Direction dir)
        {
            Direction = dir;
        }
    }
}
