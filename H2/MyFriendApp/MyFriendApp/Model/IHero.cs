using MyFriendApp.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model
{
    public interface IHero : IState
    {
        bool Sleeping { get; set; }
        int Happiness { get; set; }
        int Fatigue { get; set; }
        int Hunger { get; set; }
        IState CurrentState { get; set; }
        IState MoodState { get; set; }
        IState SleepyState { get; set; }
        IState HungryState { get; set; }
        void ChangeState(IState state);
        // This event is called when a value is changed inside Hero
        event EventHandler ValueChanged;
        void OnValueChanged(EventArgs ea);
    }
}
