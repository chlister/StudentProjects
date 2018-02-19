using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	class Parallelogram : ISquare
	{
		public string Name { get; set; } = "Paralellogram";
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }
		public double SideD { get; set; }
		public double SmallAngle { get; set; }
		/// <summary>
		/// Expects that you know the length and width plus the smallest angle
		/// </summary>
		/// <param name="length">Length</param>
		/// <param name="width">Width</param>
		/// <param name="smallAngle">Small angle</param>
		public Parallelogram(double length, double width, double smallAngle)
		{
			SideA = length;
			SideB = width;
			SmallAngle = smallAngle;
		}

		public double Area()
		{
			double area = SideA * SideB * Math.PI * SmallAngle / 180;
			return area;
		}

		public double Perimeter()
		{
			double per = (2 * SideA) + (2 * SideB);
			return per;
		}
	}
}
