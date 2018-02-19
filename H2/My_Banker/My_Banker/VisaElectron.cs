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
	/// The Visa Electron card
	/// </summary>
	class VisaElectron : DebitCard, IMonthlyLimit, IExpirable, IInternationalUse, IUsableOnline
	{
		public override int CardNumberLength { get; protected set; } = 16;
		public int MonthlyLimit { get; } = 10000;
		public DateTime ExpiryDate { get; set; }
		public bool UsableInternationaly { get; } = true;
		public bool UsableOnline { get; } = true;
		public override char[] CardPrefix { get; protected set; } = { '4', '0', '2', '6' };

		public VisaElectron(string cardholder) : base(cardholder)
		{
			ExpiryDate = ExpiryDateCalculator.GetExpiryDate(60);
		}
		/// <summary>
		/// Overrides the ToString() method to show the info of the object
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return base.ToString() + $" MonthlyLimit: {MonthlyLimit}. Expiry Date: {ExpiryDate.ToString("MM/yy")}. Online use: {UsableOnline}. International use: {UsableInternationaly}";
		}
	}
}
