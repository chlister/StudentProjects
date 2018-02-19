using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
	interface ICharacter
	{
		void ThrowMagicMisile();
		void Heal();
		void Die();
		void ThrowFrostNova();
		void RaiseShield();
		void Fight();
		void Teleport(int x, int y);
		void Bash();
		void Cleave();
		void Slash();
		void ShieldGlare();
	}
}
