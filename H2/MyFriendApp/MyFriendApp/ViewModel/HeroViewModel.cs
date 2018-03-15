using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MyFriendApp.Model;
using System.Diagnostics;
using MyFriendApp.Model.State;

namespace MyFriendApp.ViewModel
{
    class HeroViewModel : ViewModelBase
    {
        private IHero hero;
        private int fatigue;

        public int Fatigue
        {
            get { return fatigue; }
            set
            {
                fatigue = value;
                OnPropertyChanged();
            }
        }

        private int hungry;
        public int Hungry
        {
            get { return hungry; }
            set
            {
                hungry = value;
                OnPropertyChanged();
            }
        }

        public HeroViewModel()
        {
            // Start the Hero
            hero = new Hero();
            Hungry = hero.Hunger;
            Fatigue = hero.Fatigue;
            hero.ValueChanged += ValueChanged;

        }
        private void ValueChanged(object sender, EventArgs ea)
        {
            ValueEventArgs vc = (ValueEventArgs)ea;
            if (vc.State != null)
            {
                Debug.WriteLine("Value Changed + " + vc.State.ToString());
            }
            if (vc.State is HungryState)
            {
                Hungry = vc.Value;
                Fatigue = vc.Value;
            }
        }
        public void Feed()
        {
            hero.Feed();
        }
        public void Sleep()
        {
            hero.Sleep();
        }

    }
}
