using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    class DragonAdapter : IFighter
    {
        private int turn = 1;
        public int DefenseLeft { get; private set; }
        Dragon drake;
        public DragonAdapter(Dragon drake)
        {
            this.drake = drake;
            // Sets the drakes DefenseLeft
            DefenseLeft = drake.Defense();
        }
        public int Attack()
        {
            // on turn 1 ||2 dragon breathes fire!
            if (turn == 1 || turn == 2)
            {
                // increment turn
                turn++;
                return drake.BreatheFire();
            }
            else
            {
                // If turn is 4 or it is more - shouldn't happend - reset turn to 1. Or else increment
                if (turn >=4)
                {
                    turn = 1;
                }
                else
                {
                    turn++;
                }
                return drake.TaleSlash();
            }
        }

        public void Defend(int attack)
        {
            drake.Defend(attack);
        }

        public bool HasEscaped()
        {
            return drake.IsFlyingAway();
        }
        /// <summary>
        /// So i can check who wins!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dragon";
        }
    }
}
