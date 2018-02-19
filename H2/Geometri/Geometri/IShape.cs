using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	/// <summary>
	/// Interface with methods for calculating shapes
	/// </summary>
	public interface IShape
	{
		string Name { get; set; }
		double Area();
		double Perimeter();
	}
}
