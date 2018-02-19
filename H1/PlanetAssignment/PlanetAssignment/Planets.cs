using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAssignment
{
    public class Planets
    {
        #region Properties

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        private int density;

        public int Density
        {
            get { return density; }
            set { density = value; }
        }
        private double gravity;

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }
        private double rotationPeriod;

        public double RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }
        private double lenghtOfDays;

        public double LengthOfDays
        {
            get { return lenghtOfDays; }
            set { lenghtOfDays = value; }
        }
        private double distanceFromSun;

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }
        private double orbitalPeriod;

        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }
        private double orbitalVelocity;

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }
        private short meanTemperatur;

        public short MeanTemperatur
        {
            get { return meanTemperatur; }
            set { meanTemperatur = value; }
        }
        private byte numberOfMoons;

        public byte NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }
        private bool isRingSystem;

        public bool IsRingSystem
        {
            get { return isRingSystem; }
            set { isRingSystem = value; }
        }
        #endregion Properties

        public Planets()
        {

        }
        public Planets(string _name, double _mass, double _diameter, int _density, double _gravity, double _rotationPeriod, double _lengthOfDays, double _distanceFromSun, double _orbitalPeriod, double _orbitalVelocity, short _meanTemperatur, byte _numberOfMoons, bool _isRingSystem)
        {
            Name = _name;
            Mass = _mass;
            Diameter = _diameter;
            Density = _density;
            Gravity = _gravity;
            RotationPeriod = _rotationPeriod;
            LengthOfDays = _lengthOfDays;
            DistanceFromSun = _distanceFromSun;
            OrbitalPeriod = _orbitalPeriod;
            OrbitalVelocity = _orbitalVelocity;
            MeanTemperatur = _meanTemperatur;
            NumberOfMoons = _numberOfMoons;
            IsRingSystem = _isRingSystem;
        }

    }
}
