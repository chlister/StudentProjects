using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	/// <summary>
	/// Interface for all Squares
	/// </summary>
	public interface ISquare : IShape
	{
		double SideA { get; set; }
		double SideB { get; set; }
		double SideC { get; set; }
		double SideD { get; set; }
	}
}
