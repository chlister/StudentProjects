using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
	/// <summary>
	/// Interface for all triangles
	/// </summary>
	public interface ITriangle : IShape
	{
		double SideA { get; set; }
		double SideB { get; set; }
		double SideC { get; set; }
	}
}
