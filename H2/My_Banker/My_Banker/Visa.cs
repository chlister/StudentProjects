using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// The Visa card class
	/// </summary>
	public class Visa : CreditCard, IMonthlyLimit, IExpirable
	{

		public int MonthlyLimit { get; } = 20000;
		public override int CreditLimit { get; protected set; } = 25000;
		public override int CardNumberLength { get; protected set; } = 16;
		public override char[] CardPrefix { get; protected set; } = { '4' };
		public DateTime ExpiryDate { get; set; }
		public Visa(string cardholder) : base(cardholder)
		{
			ExpiryDate = ExpiryDateCalculator.GetExpiryDate(60);
		}
		/// <summary>
		/// Overrides the ToString() method to show the info of the object
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return base.ToString() + $" MonthlyLimit: { MonthlyLimit}. Expiry Date: { ExpiryDate.ToString("MM/yy")}. Credit limit: {CreditLimit}";
		}
	}
}
