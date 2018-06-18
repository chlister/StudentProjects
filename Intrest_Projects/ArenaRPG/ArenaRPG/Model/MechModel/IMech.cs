using System.Collections.Generic;

namespace ArenaRPG.Model.MechModel
{
    public interface IMech
    {
        List<IMechPart> Parts { get; }
        IHead Head { get; set; }
        IChest Chest { get; set; }
        ILeg LegLeft { get; set; }
        ILeg LegRight { get; set; }
        IArm ArmLeft { get; set; }
        IArm ArmRight { get; set; }
        void TargetMechPart(IMechPart mechPart);
    }
}
