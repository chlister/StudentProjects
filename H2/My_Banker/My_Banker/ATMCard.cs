using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
	class ATMCard : DebitCard
	{

		public override int CardNumberLength { get; protected set; } = 16;
		public override char[] CardPrefix { get; protected set; } = { '2', '4', '0', '0' };

		public ATMCard(string cardholder) : base(cardholder)
		{

		}

	}
}
