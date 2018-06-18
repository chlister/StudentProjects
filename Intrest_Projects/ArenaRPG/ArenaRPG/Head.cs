﻿namespace ArenaRPG
{
    public class Head : IHead
    {
        private int _HealthPoint;
        public int HealthPoint
        {
            get { return _HealthPoint; }
            set
            {
                _HealthPoint = value;
                if (HealthPoint <= 0)
                {
                    IsActive = false;
                }
            }
        }
        public bool IsActive { get; private set; }

        public string PartName { get; set; }

        public Head(int _hp, string _partName)
        {
            HealthPoint = _hp;
            IsActive = true;
            PartName = _partName;
        }
    }
}
