using H2_HeltIFisk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace H2_HeltIFisk.ViewModel
{
    /// <summary>
    /// Limen fra animal til view
    /// </summary>
    public class AnimalViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Animal> animals = new ObservableCollection<Animal>();
        private string imageSource;
        private Animal currentAnimal;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Animal> Animals
        {
            get => animals;
            set => animals = value;
        }

        public string ImageSource { get => imageSource; set => imageSource = value; }
        public Animal CurrentAnimal
        {
            get => currentAnimal;
            set
            {
                currentAnimal = value;
                OnPropertyChanged("CurrentAnimal");
            }
        }

        public AnimalViewModel()
        {
            //Animal clownFish = new Animal("Clownfish", 0.05F, 0.10F);
            //Animal shark = new Animal("Shark", 1100F, 6F);
            //Animal dolphin = new Animal("Dolphin", 400, 3);
            animals.Add(new Animal("Clownfish", 0.05F, 0.10F));
            animals.Add(new Animal("Shark", 1100F, 6F));
            animals.Add(new Animal("Dolphin", 400, 3));
            CurrentAnimal = animals[0];
        }
        //det er denne metode der kaldes, når der skal kastes en event
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
