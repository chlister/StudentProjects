using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Banker
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creating cards: ");
			List<Card> cards = new List<Card>()
			{
				new VisaElectron("Marc"),
				new ATMCard("David"),
				new Visa("Fiddi"),
				new MasterCard("Jane"),
				new Meastro("Nikolas")
		};
			foreach (Card item in cards)
			{
				Console.WriteLine(item.ToString());
			}
            cards[0].Deposit(500);

			Console.ReadLine();
		}
	}
}
