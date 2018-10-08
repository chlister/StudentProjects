using System;

namespace ArduinoOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            JoystickOutput js = new JoystickOutput();
            js.DirectionChanged += Js_DirectionChanged;
            js.ButtonPressed += Js_ButtonPressed;
            while (true)
            {

            }

        }

        private static void Js_ButtonPressed(object sender, ButtonEventArgs<Button> e)
        {
            Console.WriteLine(e.Button);
        }

        private static void Js_DirectionChanged(object sender, DirectionEventArgs dea)
        {
            Console.WriteLine(dea.Direction);
        }
    }
}
