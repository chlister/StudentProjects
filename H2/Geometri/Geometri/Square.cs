using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	public class Square : ISquare
	{
		// Hej camilla - bum bum nu kan jeg ikke lave mine setter private ! :O
		public string Name { get; set; } = "Square";
		public double SideA { get;  set; }
		public double SideB { get;  set; }
		public double SideC { get;  set; }
		public double SideD { get;  set; }

		/// <summary>
		/// Expects a perfect square, therefore just one side is needed
		/// </summary>
		/// <param name="sideA"></param>
		public Square(double sideA)
		{
			SideA = sideA;
			SideB = SideA;
			SideC = SideA;
			SideD = SideA;
		}
		/// <summary>
		/// Calculates the area of a Square
		/// </summary>
		/// <returns></returns>
		public virtual double Area()
		{
			try
			{
				double a = SideA * 2;
				return a;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
		/// <summary>
		/// Calculates the perimeter of a Square
		/// </summary>
		/// <returns></returns>
		public virtual double Perimeter()
		{
			try
			{
				double per = SideA * 4;
				return per;
			}
			catch (Exception e)
			{

				throw e;
			}
		}
	}
}
