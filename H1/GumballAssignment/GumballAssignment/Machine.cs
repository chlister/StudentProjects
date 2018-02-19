using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballAssignment
{
    class Machine
    {
        public List<Gumball> contents = new List<Gumball>();
        #region Fields
        private string name;
        #endregion
        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        public void PopulateMachine()
        {
            
        }
    }
}
