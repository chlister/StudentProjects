using ArenaRPG.Model.MechModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaRPG.View
{
    public class MechView
    {
        public IMech Mech { get; set; }
        public MechView(IMech mech)
        {
            Mech = mech;
        }

        public void ShowMechParts()
        {
            // Show all parts of the mech - remember some parts may be missing
            Console.WriteLine("Mech overview:");
            foreach (var part in Mech.Parts)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(part.PartName + "\nIs Functional: "+part.IsActive);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ReadKey();
        }

    }
}
