﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
	class Witch : ICharacter
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
			Console.WriteLine("I'm raising my shield");
		}

		public void ShieldGlare()
		{
			Console.WriteLine("I'm throwing shield glare");
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
			throw new NotImplementedException();
		}

		public void ThrowMagicMisile()
		{
			throw new NotImplementedException();
		}
	}
}
