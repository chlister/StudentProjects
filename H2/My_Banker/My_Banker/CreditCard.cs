using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Abstract class for specifying the creditcard class
	/// </summary>
	public abstract class CreditCard : Card
	{
		public abstract int CreditLimit { get; protected set; }
		public CreditCard(string cardholder) : base(cardholder)
		{

		}

		/// <summary>
		/// To control the withdraw method
		/// </summary>
		/// <param name="amount">Amount to be withdrawn</param>
		/// <returns></returns>
		public override void Withdraw(int amount)
		{
			Balance -= amount;
		}
		public override string ToString()
		{
			return $"Cardholder: {CardHolder}. Cardnumber: {ConvertCharArr(CardNumber)}. Accountnumber: {ConvertCharArr(AccountNumber)}";
		}
	}
}
