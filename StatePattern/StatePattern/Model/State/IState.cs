using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model.State
{
    /// <summary>
    /// Used to define all the methods our Hero can do
    /// </summary>
    public interface IState
    {
        void SaveTheDay();
        void BattleVillain();
        void Eat();
        void Sleep();
    }
}
