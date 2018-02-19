using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
	class Knight : ICharacter
	{
		public void Bash()
		{
			Console.WriteLine("I'm bashing someone");
		}

		public void Cleave()
		{
			Console.WriteLine("I'm cleaving someone");
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Fight()
		{
			Console.WriteLine("I'm fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void RaiseShield()
		{
			Console.WriteLine("I'm raising my shield");
		}

		public void ShieldGlare()
		{
			Console.WriteLine("I'm throwing shield glare");
		}

		public void Slash()
		{
			Console.WriteLine("I'm slashing someone");
		}

		public void Teleport(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void ThrowFrostNova()
		{
			throw new NotImplementedException();
		}

		public void ThrowMagicMisile()
		{
			throw new NotImplementedException();
		}
	}
}
