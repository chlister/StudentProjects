using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    public class Dragon
    {

        private Random r = new Random();
        private float defend = 50;
        private bool flyAway = false;


        public int BreatheFire()
        {
            return 10;
        }


        public int TaleSlash()
        {
            return 1;
        }


        public void Defend(int attack)
        {
            defend -= attack;
            if (r.Next(100) <= 20)
            {
                flyAway = true;
            }
        }

        public bool IsFlyingAway()
        {
            return flyAway;
        }

        public int Defense()
        {
            return (int)Math.Round(defend);
        }

    }
}
