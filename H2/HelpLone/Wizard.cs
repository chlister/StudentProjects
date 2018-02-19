using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
	class Wizard : ICharacter
	{
		public void Bash()
		{
			throw new NotImplementedException();
		}

		public void Cleave()
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public void ShieldGlare()
		{
			throw new NotImplementedException();
		}

		public void Slash()
		{
			throw new NotImplementedException();
		}

		public void Teleport(int x, int y)
		{
			Console.WriteLine("I'm teleporting to " + x + " " + y);
		}

		public void ThrowFrostNova()
		{
			Console.WriteLine("I'm throwing my frost nova");
		}

		public void ThrowMagicMisile()
		{
			Console.WriteLine("I'm throwing a magic misile");
		}
	}
}
