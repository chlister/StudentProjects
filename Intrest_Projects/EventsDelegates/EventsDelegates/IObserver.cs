using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    interface IObserver
    {
        /// <summary>
        /// Method should be used to handle an event.
        /// </summary>
        /// <param name="e"></param>
        void OnValueChanged(EventArgs e);
    }
}
