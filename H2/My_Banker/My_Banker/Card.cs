using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Banker
{
	/// <summary>
	/// Superclass for all cards 
	/// </summary>
	public abstract class Card
	{
		protected int accountNumLength = 14;
		public abstract int CardNumberLength { get; protected set; }
		public abstract char[] CardPrefix { get; protected set; }
		public char[] RegNumber { get; } = { '3', '5', '2', '0' };
		public char[] CardNumber { get; protected set; }
		public string CardHolder { get; protected set; }
		public char[] AccountNumber { get; protected set; }
		public int Balance { get; protected set; }
		protected Card(string cardholder)
		{
			// The super class makes sure that every card is given a account number + card number
			CardHolder = cardholder;
			AccountNumber = GenerateAccount();
			CardNumber = GenerateCardNumber();
		}
		/// <summary>
		/// Method for withdrawing a specified amount from balance
		/// </summary>
		/// <param name="amount"></param>
		public abstract void Withdraw(int amount);

		/// <summary>
		/// Method for depositing a certain amount to the card
		/// </summary>
		/// <param name="Amount">Amount to be deposited</param>
		protected void Deposit(int Amount)
		{
			Balance += Amount;
		}
		/// <summary>
		/// Generates a random account number with the specified regnumber
		/// </summary>
		/// <returns></returns>
		protected char[] GenerateAccount()
		{
			Random rnd = new Random();
			// Generating a char[] to match length of account number
			char[] acc = new char[accountNumLength];
			for (int i = 0; i < accountNumLength; i++)
			{
				// Inserting the prefix regnumber
				for (int j = 0; j < RegNumber.Length; j++)
				{
					acc[j] = RegNumber[j];
				}
				Thread.Sleep(50);
				// Inserting random numbers in the remaining spaces
				acc[i] = Convert.ToChar(Convert.ToString(rnd.Next(0, 9)));
			}
			return acc;
		}
		/// <summary>
		/// Abstract ToString() method for later use in the heritance tree.
		/// </summary>
		/// <returns></returns>
		public abstract string ToString();
		/// <summary>
		/// Method returns a string of a given char[]
		/// </summary>
		/// <param name="chars"></param>
		/// <returns></returns>
		protected string ConvertCharArr(char[] chars)
		{
			StringBuilder str = new StringBuilder();
			foreach (var item in chars)
			{
				str.Append(item.ToString());
			}
			return str.ToString();
		}
		/// <summary>
		/// Method for generating the card number with the specified cardnumber prefix and cardnumber length
		/// </summary>
		/// <param name="cardPrefix"></param>
		/// <param name="cardLength"></param>
		/// <returns></returns>
		protected char[] GenerateCardNumber()
		{
			Random rnd = new Random();
			char[] arr = new char[CardNumberLength];
			for (int i = 0; i < CardNumberLength; i++)
			{
				// Iterates through cardprefix and adds it to the card number
				for (int j = 0; j < CardPrefix.Length; j++)
				{
					arr[j] = CardPrefix[j];
				}
				Thread.Sleep(50);
				// generates random numbers for the rest of the char[]
				arr[i] = Convert.ToChar(Convert.ToString(rnd.Next(0, 9)));
			}
			return arr;
		}
	}
}
