using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControl;
using CustomControl.Input;
using CustomControl.Event;


namespace TestLibraryoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectSerial cs = new ConnectSerial("COM6", 9600);
            cs.CuttingButtonPressed += Cs_CuttingButtonPressed;
            cs.OpenConnection();

            while (true)
            {

            }
        }

        private static void Cs_CuttingButtonPressed(object sender, ButtonEventArgs<CuttingButtons> bea)
        {
            Console.WriteLine(bea.Button);
        }
    }
}
