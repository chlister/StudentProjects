using System;

namespace ArduinoOutput
{
    public class ButtonEventArgs<T> : EventArgs
    {
        public T Button { get; }
        public ButtonEventArgs(T button)
        {
            Button = button;
        }
    }
}
