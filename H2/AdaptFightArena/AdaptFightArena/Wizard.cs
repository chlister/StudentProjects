using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    public class Wizard
    {
        private double defend = 20;
        private bool portalOpen = false;
        private Random r = new Random();

        public int CastFireballSpell()
        {
            return r.Next(10);
        }

        public void Shield(int hits)
        {
            // der kastes et shield som tager noget af slaget
            Random r = new Random();
            int protection = r.Next(100);

            // et shield kan beskytte 0-100%
            defend -= (protection / 100) * defend;
            // Der 29% chance for at en Wizard bliver bange
            if (r.Next(29) <= 5)
            {
                portalOpen = true;
            }

        }

        public bool IsPortalOpened()
        {
            return portalOpen;
        }

        public int DefenseLeft()
        {
            return (int)Math.Round(defend);
        }
    }
}
