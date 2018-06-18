using System;

namespace ArenaRPG
{
    public class Mech : IMech
    {
        public IHead Head { get; set; }
        public IChest Chest { get; set; }

        public void TargetMechPart(IMechPart mechPart)
        {
            Console.WriteLine("Targeting " + mechPart.PartName);
        }

        public Mech()
        {

        }

        public Mech(IChest _chest, IHead _head)
        {
            Head = _head;
            Chest = _chest;
        }
    }
}
