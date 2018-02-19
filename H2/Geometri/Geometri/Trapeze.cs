using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	/// <summary>
	/// The Trapeze Object
	/// </summary>
	class Trapeze : ISquare
	{
		public string Name { get; set; } = "Trapeze";
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }
		public double SideD { get; set; }
		public double Height { get; set; }
		/// <summary>
		/// Constructor for a trapeze. The sides are same size.
		/// </summary>
		/// <param name="length">Top side</param>
		/// <param name="lengthButtom">Buttom side</param>
		/// <param name="widthA">Left side</param>
		public Trapeze(double length, double lengthButtom, double widthA)
		{
			SideA = length;
			SideB = lengthButtom;
			SideC = widthA;
			SideD = widthA;
			Height = CalcHeight();
		}
		/// <summary>
		/// Calculates the height of the Trapeze for later use
		/// </summary>
		/// <returns></returns>
		private double CalcHeight()
		{
			try
			{
				double h = (SideA + SideC - SideA + SideB) / 2;
				double b = (2 / (SideA - SideA)) * (Math.Sqrt(h * (h - SideA + SideA) * (h - SideC) * (h - SideB)));
				return b;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
		/// <summary>
		/// Calculates the Area of a Trapeze
		/// </summary>
		/// <returns></returns>
		public double Area()
		{
			try
			{
				double a = 0.5 * (SideA + SideA) * SideD;
				return Convert.ToInt32(a);
			}
			catch (Exception e)
			{

				throw e;
			}
		}
		/// <summary>
		/// Calculates the perimeter of a Trapeze
		/// </summary>
		/// <returns></returns>
		public double Perimeter()
		{
			try
			{
				double a = SideA + SideA + SideB + SideC;
				return a;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
	}
}
