using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Interface adding a Expirydate property
	/// </summary>
	public interface IExpirable
	{
		DateTime ExpiryDate { get; set; }
	}
}