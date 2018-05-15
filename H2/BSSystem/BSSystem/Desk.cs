using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSSystem.Models;
using BSSystem.Utils;

namespace BSSystem
{
    /// <summary>
    /// Desk class for taking bags from passengers
    /// </summary>
    class Desk
    {
        public string Name { get; set; }

        #region Constructor
        public Desk(string _name)
        {
            Name = _name;
        }
        #endregion
        #region Methods
        public void HandleBag(Bagage bag)
        {
            // Generates and tags a bag with a unique tag
            bag.BagTag = Tagger.GenTag();
            // notify server
            NotifyServer(bag, 2);
            // sendes videre til sorting
            Sendtosort(bag);
        }

        private void Sendtosort(Bagage bag)
        {
            // Send bag to sorting
            SortingMachine.Instance.RecieveFromDesk(bag);
        }

        private void NotifyServer(Bagage bag, int status)
        {
            // Notifies the server of a new bag wich is being send to sorting
            CentralServer.Instance.CreateBag(bag, status);
        }
        #endregion
    }
}
