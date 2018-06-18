namespace ArenaRPG.Model.MechModel
{
    public interface IArm : IMechPart
    {
        Weapon Weapon { get; set; }
    }
}
