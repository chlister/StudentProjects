using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateAss
{
    /// <summary>
    /// Class made for boiling
    /// </summary>
    public abstract class Boiler
    {
        /// <summary>
        /// Method boils water
        /// </summary>
        /// <returns></returns>
        protected string BoilWater()
        {
            return "Boiling water...";
        }
        /// <summary>
        /// Method sends water to the next step
        /// </summary>
        /// <returns></returns>
        protected string Pour()
        {
            return "Pouring the boiled water...";
        }
        /// <summary>
        /// ToString is being used to write what is happening
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    }
}
