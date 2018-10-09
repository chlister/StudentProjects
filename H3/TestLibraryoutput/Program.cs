using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControl;
using CustomControl.Input;
using CustomControl.Event;
using System.IO.Ports;

namespace TestLibraryoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectSerial cs = new ConnectSerial();
            cs.CuttingButtonPressed += Cs_CuttingButtonPressed;
            cs.CuttingAction += Cs_CuttingAction;
            cs.OpenConnection();
            Console.ReadLine();
        }

        private static void Cs_CuttingAction(object sender, CuttingEventArgs e)
        {
            Console.WriteLine("CUTTING!!!!!!");
        }

        private static void Cs_CuttingButtonPressed(object sender, ButtonEventArgs<CuttingButtons> bea)
        {

            Console.WriteLine("Cutton button pressed " +bea.Button);
        }
    }
}
