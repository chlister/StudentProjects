using System;

namespace CustomControl.Event
{
    public class ButtonEventArgs<T> : EventArgs  
    {
        public T Button { get;}
        public ButtonEventArgs(T button)
        {
            Button = button;
        }
    }
}
