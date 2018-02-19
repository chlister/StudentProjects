using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	class Program
	{
		static void Main(string[] args)
		{
			// Test Square
			try
			{


				// Test Square
				Square square = new Square(6);
				Console.WriteLine("Square Test");
				Console.WriteLine(square.Area());
				Console.WriteLine(square.Perimeter());
				Console.WriteLine("--------------------------------------------------------");

				// Test Rectangle
				Rectangle rect = new Rectangle(4, 12);
				Console.WriteLine("Rectangle Test");
				Console.WriteLine(rect.Area());
				Console.WriteLine(rect.Perimeter());
				Console.WriteLine("--------------------------------------------------------");
				// Test Trapeze
				Trapeze trap = new Trapeze(5, 10, 13);
				Console.WriteLine("Rectangle Test");
				Console.WriteLine(trap.Area());
				Console.WriteLine(trap.Perimeter());
				Console.WriteLine("--------------------------------------------------------");
				// Test Parallelogram
				Parallelogram para = new Parallelogram(8, 12, 46);
				Console.WriteLine("Parallelogram Test");
				Console.WriteLine(para.Area());
				Console.WriteLine(para.Perimeter());
				Console.WriteLine("--------------------------------------------------------");
				// Test Triangle
				Triangle tri = new Triangle(10, 8);
				Console.WriteLine("Triangle Test");
				tri.Area();
				tri.Perimeter();

				// Put one of each in a List
				List<IShape> shapes = new List<IShape>()
				{
					new Triangle(13, 22),
					new Square(20),
					new Parallelogram(12, 20, 56),
					new Trapeze(30, 56, 22),
					new Rectangle(42, 32)
				};
				Console.WriteLine("------------ TESTING THE LIST --------------------------");
				foreach (IShape item in shapes)
				{
					Console.WriteLine(item.Name);
					Console.WriteLine(item.Area());
					Console.WriteLine(item.Perimeter());
					Console.WriteLine("--------------------------------------------------------");
				}


			}
			catch (Exception e)
			{
				Console.WriteLine("Error thrown: " + e.Message);
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.TargetSite);
			}
			Console.ReadLine();
		}
	}
}
