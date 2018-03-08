using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilos
{
    class Philosopher
    {
        private Thread Philo;
        public string Name { get; }
        public Philosopher(string _name)
        {
            Philo = new Thread(this.Run);
            Name = _name;
        }
        void Run()
        {

        }
    }
}
