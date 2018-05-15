using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    interface IObservable
    {
        /// <summary>
        /// Event that can be subscribed to - Class that implement needs to invoke the event when changes happend
        /// </summary>
        event EventHandler ValueChanged;
    }
}
