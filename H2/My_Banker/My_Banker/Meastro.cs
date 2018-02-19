using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// The meastro class
	/// </summary>
	public class Meastro : DebitCard, IExpirable, IInternationalUse, IUsableOnline
	{

		public override int CardNumberLength { get; protected set; } = 19;
		public override char[] CardPrefix { get; protected set; } = { '5', '0', '1', '8' };
		public DateTime ExpiryDate { get ; set; }
		public bool UsableInternationaly { get; } = true;
		public bool UsableOnline { get; } = true;
		public Meastro(string cardholder) : base(cardholder)
		{
			ExpiryDate = ExpiryDateCalculator.GetExpiryDate(68);
		}
		/// <summary>
		/// Overrides the ToString() method to show the info of the object
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return base.ToString() + $" Expiry Date: {ExpiryDate.ToString("MM/yy")}. Online use: {UsableOnline}. International use: {UsableInternationaly}";
		}
	}
}
