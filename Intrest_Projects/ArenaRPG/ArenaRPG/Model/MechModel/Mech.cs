using System;
using System.Collections.Generic;

namespace ArenaRPG.Model.MechModel
{
    public class Mech : IMech
    {
        private IHead _head;
        private IChest _chest;
        private ILeg _legLeft;
        private ILeg _legRight;
        private IArm _armLeft;
        private IArm _armRight;

        public IHead Head
        {
            get => _head;
            set
            {
                if (_head != null)
                {
                    Parts.Remove(_head);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _head = value;
            }
        }
        public IChest Chest
        {
            get => _chest;
            set
            {
                if (_chest != null)
                {
                    Parts.Remove(_chest);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _chest = value;
            }
        }
        public ILeg LegLeft
        {
            get => _legLeft;
            set
            {
                if (_legLeft != null)
                {
                    Parts.Remove(_legLeft);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _legLeft = value;
            }
        }
        public ILeg LegRight
        {
            get => _legRight;
            set
            {
                if (_legRight != null)
                {
                    Parts.Remove(_legRight);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _legRight = value;
            }
        }
        public IArm ArmLeft
        {
            get => _armRight;
            set
            {
                if (_armRight != null)
                {
                    Parts.Remove(_armRight);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _armRight = value;
            }
        }
        public IArm ArmRight
        {
            get => _armRight;
            set
            {
                if (_armRight != null)
                {
                    Parts.Remove(_armRight);
                    Parts.Add(value);
                }
                else
                {
                    Parts.Add(value);
                }
                _armRight = value;
            }
        }

        public List<IMechPart> Parts { get; private set; }

        public void TargetMechPart(IMechPart mechPart)
        {
            try
            {
                Console.WriteLine("Targeting " + mechPart.PartName);

            }
            catch (Exception)
            {

            }
        }

        public Mech()
        {
            Parts = new List<IMechPart>();
        }

        public Mech(IChest _chest, IHead _head) : base()
        {
            Head = _head;
            Chest = _chest;
        }
    }
}
