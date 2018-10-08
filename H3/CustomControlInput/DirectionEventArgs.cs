using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlInput
{
public    class DirectionEventArgs : EventArgs
    {
        public Directions Direction { get; set; }
        public DirectionEventArgs(Directions dir)
        {
            Direction = dir;
        }
    }
    public enum Directions
    {
        Up,
        Down,
        Left,
        Right
    }
}
