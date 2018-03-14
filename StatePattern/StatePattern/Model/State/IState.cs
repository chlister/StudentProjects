using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model.State
{
    public interface IState : IHero
    {
        void SaveTheDay();
        void BattleVillain();
        void Eat();
        void Sleep();
    }
}
