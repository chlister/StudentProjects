using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    class WizardAdapter : IFighter
    {
        public int DefenseLeft { get; private set; }
        Wizard wiz;
        public WizardAdapter(Wizard wiz)
        {
            this.wiz = wiz;
            DefenseLeft = wiz.DefenseLeft();
        }
        public int Attack()
        {
            return wiz.CastFireballSpell();
        }

        public void Defend(int attack)
        {
            wiz.Shield(attack);
        }

        public bool HasEscaped()
        {
            return wiz.IsPortalOpened();
        }
        /// <summary>
        /// So i can check who wins!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Wizard";
        }
    }
}
