using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Class for the master card
	/// </summary>
	class MasterCard : CreditCard, IExpirable, IDailyLimit, IMonthlyLimit
	{

		public int MonthlyLimit { get; } = 30000;
		public override int CreditLimit { get; protected set; } = 40000;
		public override int CardNumberLength { get; protected set; } = 16;
		public override char[] CardPrefix { get; protected set; } = { '5', '3' };
		public DateTime ExpiryDate { get; set; }
		public int DailyLimit { get; set; } = 5000;


		public MasterCard(string cardholder) : base(cardholder)
		{
			ExpiryDate = ExpiryDateCalculator.GetExpiryDate(60);
		}
		/// <summary>
		/// Overrides the ToString() method to show the info of the object
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return base.ToString() + $" MonthlyLimit: {MonthlyLimit}. Expiry Date: {ExpiryDate.ToString("MM/yy")}. Credit limit: {CreditLimit}. Daily limit: {DailyLimit}";		}
	}
}
