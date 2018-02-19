using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateAss
{
    /// <summary>
    /// The traditional coffeedispenser we all know
    /// </summary>
    public abstract class CoffeeDispenser : Boiler
    {
        /// <summary>
        /// Brew method contains different ingredients so it's abstract
        /// </summary>
        /// <returns></returns>
        protected abstract string Brew();
        public abstract override string ToString();
    }
}
