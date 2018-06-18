
namespace ArenaRPG.Model.MechModel
{
    public abstract class MechPart : IMechPart
    {
        protected int _healthPoint = 50;
        public int HealthPoint
        {
            get { return _healthPoint; }
            set
            {
                _healthPoint = value;
                if (HealthPoint <= 0)
                {
                    IsActive = false;
                }
            }
        }

        public bool IsActive { get; protected set; } = true;

        public string PartName { get ; set ; }

        public MechPart(int _hp, string _partName)
        {
            HealthPoint = _hp;
            PartName = _partName;
        }
    }
}
