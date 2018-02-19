using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Class is used to calculate the expiry date for our cards
	/// </summary>
	public class ExpiryDateCalculator
	{
		/// <summary>
		/// Method returns a DateTime object where int month has been added to the date
		/// Method is static because it doesn't make sense to instantiate a calculating class - it doesn't need to store anything, just give results
		/// </summary>
		/// <param name="month"></param>
		/// <returns></returns>
		internal static DateTime GetExpiryDate(int month)
		{
			DateTime date = DateTime.Now.AddMonths(month);
			// Changes the way the object handles tostring method - used because on my system it would return 02-18 and i need it to be 02/18 - US standard
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			return date;
		}
	}
}
