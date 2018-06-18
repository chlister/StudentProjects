using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ArenaRPG.Annotations;

namespace ArenaRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            IMech mech = new Mech(new Chest(150, "Basic Chest Piece"), new Head(50, "Basic Head Piece"));

            mech.TargetMechPart(mech.Chest);

            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
