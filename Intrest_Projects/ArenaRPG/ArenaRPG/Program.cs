using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ArenaRPG.Annotations;

namespace ArenaRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            IMech mech = new Mech(new Chest(150, "Basic Chest Piece"), new Head(50, "Basic Head Piece"));

            mech.TargetMechPart(mech.Chest);

            Console.WriteLine("Hello");
            Console.ReadLine();
        }


    }

    public interface IMechPart
    {
        int HealthPoint { get; set; }
        bool IsActive { get; }
        string PartName { get; set; }
    }

    public interface IHead : IMechPart
    {

    }
    public interface IChest : IMechPart
    {

    }

    public class Chest : IChest
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

        public Chest(int _hp, string _partName)
        {
            HealthPoint = _hp;
            IsActive = true;
            PartName = _partName;
        }


    }

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

    public interface IMech
    {
        IHead Head { get; set; }
        IChest Chest { get; set; }

        void TargetMechPart(IMechPart mechPart);
    }

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

    public class Counter
    {
        public event EventHandler ThresholdReached;

        public void Count()
        {
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                counter++;
                if (counter == 50)
                {

                }
            }
        }


        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class Display
    {
        public Display()
        {

        }

        public string Message(string mes)
        {

            return mes;
        }
    }
}
