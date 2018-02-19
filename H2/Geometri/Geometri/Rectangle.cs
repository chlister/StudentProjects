using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	class Rectangle : ISquare
	{
		public string Name { get; set; } = "Rectangle";
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }
		public double SideD { get; set; }

		/// <summary>
		/// Constructor for a Rectangle
		/// </summary>
		/// <param name="sideA">Width</param>
		/// <param name="sideB">Length</param>
		public Rectangle(double sideA, double sideB)
		{
			SideA = sideA;
			SideB = SideB;
		}
		/// <summary>
		/// Calculates the area of a Rectangle
		/// </summary>
		/// <returns></returns>
		public double Area()
		{
			try
			{
				double a = SideA * SideB;
				return a;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
		/// <summary>
		/// Calculates the perimeter of a Rectangle
		/// </summary>
		/// <returns></returns>
		public double Perimeter()
		{
			try
			{
				double per = 2 * (SideA + SideB);
				return per;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
	}
}
