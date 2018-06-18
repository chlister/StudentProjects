using ArenaRPG.Model.MechModel;
using ArenaRPG.Utils;

namespace ArenaRPG.Model
{
    public class MechFactory
    {
        public static IMech CreateMech()
        {
            return new Mech();
        }
        public static IMechPart CreateMechPart(PartEnum part)
        {
            switch (part)
            {
                case PartEnum.Chest:
                    return new Chest(150, "Basic Chest Part");
                case PartEnum.Leg:
                    return new Leg(100, "Basic Leg Part");
                case PartEnum.Arm:
                    return new Arm(100, "Basic Arm Part");
                case PartEnum.Head:
                    return new Head(50, "Basic Head Part");
                default:
                    return null;
            }
        }
    }
}
