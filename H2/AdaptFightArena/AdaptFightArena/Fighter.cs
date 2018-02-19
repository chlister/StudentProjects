using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    class Fighter : IFighter
    {
        public int DefenseLeft { get; private set; } = 30;

        public int Attack()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

        public void Defend(int attack)
        {
            DefenseLeft -= attack;
        }

        public bool HasEscaped()
        {
            Random rnd = new Random();
            int courage = rnd.Next(1, 100);
            if (courage <= 15)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// So i can check who wins!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Fighter";
        }
    }
}
