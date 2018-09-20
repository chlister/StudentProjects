using System;

namespace ArduinoOutput
{
    public class ButtonEventArgs : EventArgs
    {
        public Button Button { get; }
        public ButtonEventArgs(Button butt)
        {
            Button = butt;
        }
    }
}
