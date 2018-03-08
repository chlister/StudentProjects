using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSSystem.Models;

namespace BSSystem
{
    /// <summary>
    /// Singleton object of the sorting class
    /// </summary>
    public class SortingMachine
    {
        public Queue<Bagage> Bagages { get; }
        private static SortingMachine instance;
        public static SortingMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SortingMachine();
                }
                return instance;
            }
        }
        private SortingMachine()
        {
            Bagages = new Queue<Bagage>();
        }
        /// <summary>
        /// Recieving bags from Desk
        /// </summary>
        /// <param name="bag"></param>
        internal void RecieveFromDesk(Bagage bag)
        {

        }

    }
}
