namespace ArenaRPG.Model.MechModel
{
    public interface IMechPart
    {
        int HealthPoint { get; set; }
        bool IsActive { get; }
        string PartName { get; set; }
    }
}