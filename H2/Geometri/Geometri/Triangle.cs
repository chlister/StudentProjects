using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	/// <summary>
	/// Class for a perfect triangle
	/// </summary>
	class Triangle : ITriangle
	{
		public string Name { get; set; } = "Triangle";
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		/// <summary>
		/// Constructor expects a perfect square, therefore only horizontal and vertical sides are needed
		/// </summary>
		/// <param name="sideA">Length</param>
		/// <param name="sideB">Width</param>
		public Triangle(int sideA, int sideB)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = Pythag(SideA, SideB);
		}
		/// <summary>
		/// Method calculates SideC of the square
		/// </summary>
		/// <param name="sideA"></param>
		/// <param name="sideB"></param>
		/// <returns>SideC</returns>
		private double Pythag(double sideA, double sideB)
		{
			return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
		}
		/// <summary>
		/// Calculates Area of a triangle
		/// </summary>
		/// <returns></returns>
		public double Area()
		{
			return (SideA * SideB) / 2;
		}
		/// <summary>
		/// Calculates perimeter of a triangle
		/// </summary>
		/// <returns></returns>
		public double Perimeter()
		{
			return SideA + SideB + SideC;
		}
	}
}
