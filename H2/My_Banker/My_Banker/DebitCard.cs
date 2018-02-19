using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Abstract class for specifying the debitcard class
	/// </summary>
	public abstract class DebitCard : Card
	{
		public DebitCard(string cardholder) : base(cardholder)
		{

		}

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
