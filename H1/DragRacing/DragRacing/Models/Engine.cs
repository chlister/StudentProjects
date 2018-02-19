using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Models
{
	class Engine
	{
		private int curSpeed;
		#region Properties
		public int TopSpeed { get; set; }
		public int CurSpeed {
			get { return curSpeed; }
			set
			{
				curSpeed = value;
				if (curSpeed >= TopSpeed)
				{
					curSpeed = TopSpeed;
				}
			}
		}
		//private int Acceleration { get; set; }
		public double TimeToTopSpeed { get; set; }
		public int LengthToTopSpeed { get; set; }
		public string FabricatorName { get; set; }
		#endregion
		#region Constructor
		public Engine()
		{

		}
		/// <summary>
		/// Engine for a car. 
		/// </summary>
		/// <param name="_fabName">Fabricator name</param>
		/// <param name="_topSpeed">Top speed</param>
		/// <param name="_timeToTopSpeed">Time in seconds</param>
		/// <param name="_lengthToTopSpeed">Lenght in meters per second</param>
		public Engine(string _fabName, int _topSpeed, int _timeToTopSpeed, int _lengthToTopSpeed)
		{
			FabricatorName = _fabName;
			TopSpeed = _topSpeed;
			TimeToTopSpeed = _timeToTopSpeed;
			LengthToTopSpeed = _lengthToTopSpeed;
		}
		#endregion
		#region Methods
		private int Acceleration()
		{
			int speed;
			speed = 
			return speed;
		}
		#endregion
	}
}
