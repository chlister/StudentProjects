using ArenaRPG.Model;
using ArenaRPG.Model.MechModel;
using ArenaRPG.Utils;
using ArenaRPG.View;
using System;

namespace ArenaRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            IMech mech = MechFactory.CreateMech();

            mech.ArmLeft = (IArm)MechFactory.CreateMechPart(PartEnum.Arm);

            mech.TargetMechPart(mech.Chest);

            MechView view = new MechView(mech);
            view.ShowMechParts();

            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
