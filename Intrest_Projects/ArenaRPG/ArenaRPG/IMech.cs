namespace ArenaRPG
{
    public interface IMech
    {
        IHead Head { get; set; }
        IChest Chest { get; set; }

        void TargetMechPart(IMechPart mechPart);
    }
}
