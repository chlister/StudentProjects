using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainTaskTest
{
    class Program
    {
        static void Main(string[] args)
        {



            //Train t = new Train();
            //Train t2 = new Train(200, 1.3f, "Express Train");
            //Train t3 = new Train(150, 1.2f, "Cargo Train");

            //t.StartEngine();
            //t2.StartEngine();
            //t3.StartEngine();
            Console.ReadLine();
        }
    }

    public class Train
    {
        private float curSpeed = 0;
        private float maxSpeed = 0;
        private float acceleration = 1.1f;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public float Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }


        public float MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public float CurSpeed
        {
            get { return curSpeed; }
            set
            {
                curSpeed = value;
                if (curSpeed > maxSpeed)
                {
                    curSpeed = maxSpeed;
                }
            }
        }
        #region Constructors

        public Train()
        {
            MaxSpeed = 100;
            Acceleration = 1.1f;
            Name = "Default Train";
        }
        public Train(float _maxSpeed)
        {
            MaxSpeed = _maxSpeed;
        }
        public Train(float _maxSpeed, float _acceleration, string _name)
        {
            MaxSpeed = _maxSpeed;
            Acceleration = _acceleration;
            if (Acceleration < 1)
            {
                Acceleration = 1.1f;
            }
            Name = _name;
        }
        #endregion
        #region Methods

        /// <summary>
        /// Starts the train engine
        /// </summary>
        public async void StartEngine()
        {
            await Task.Run(() => EngineRun());
        }

        /// <summary>
        /// Accelerating the train 
        /// </summary>
        private void EngineRun()
        {
            while (CurSpeed < MaxSpeed)
            {
                Thread.Sleep(60);
                if (CurSpeed == 0 || CurSpeed == 1)
                    CurSpeed += 1;

                else
                    CurSpeed = CurSpeed * Acceleration;

            }
        }

        #endregion

    }
    public class City
    {
        private string name;
        private List<Train> stationedTrains;
        private List<City> connectedCities;
        private int yCord;
        private int xCord;


        public int XCord
        {
            get { return xCord; }
            set { xCord = value; }
        }


        public int YCord
        {
            get { return yCord; }
            set { yCord = value; }
        }


        public List<City> ConnectedCities
        {
            get { return connectedCities; }
            set { connectedCities = value; }
        }


        public List<Train> StationedTrains
        {
            get { return stationedTrains; }
            set { stationedTrains = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region Constructor

        public City(string _name) { }

        public City(string _name, List<City> _connections)
        {
            Name = _name;
            ConnectedCities = _connections;

        }

        #endregion

        #region Methods

        #endregion
    }

    public static class CordGenerator
    {
        private static int yCord;
        private static int xCord;


        public static int XCord
        {
            get { return xCord; }
            set { xCord = value; }
        }


        public static int YCord
        {
            get { return yCord; }
            set { yCord = value; }
        }
    }
}
