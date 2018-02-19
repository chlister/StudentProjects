using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Interface adding a dailylimit property
	/// </summary>
	public interface IDailyLimit
	{
		int DailyLimit { get; set; }
	}
}
