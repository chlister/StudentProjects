using CustomControl.Input;
using System;

namespace CustomControl.Event
{
    public class CuttingEventArgs : EventArgs
    {
        public CuttingActions Action { get; }
        public CuttingEventArgs(CuttingActions action)
        {
            Action = action;
        }
    }
}
