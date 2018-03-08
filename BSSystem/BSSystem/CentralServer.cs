using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSSystem.Models;

namespace BSSystem
{
    /// <summary>
    /// Singleton class emulating a central server
    /// </summary>
    public class CentralServer
    {
        private static CentralServer instance;
        public static CentralServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CentralServer();
                }
                return instance;
            }
        }
        #region Constructor
        private CentralServer()
        {

        }

        internal void CreateBag(Bagage bag, int status)
        {
            Console.WriteLine($"I have added bag number: {bag.BagTag}. Destination: {bag.Destination}");
        }
        #endregion
    }
}
