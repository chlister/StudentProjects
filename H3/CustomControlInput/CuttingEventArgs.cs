using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlInput
{
    class CuttingEventArgs : EventArgs
    {
        public CuttingActions Action { get; }
        public CuttingEventArgs(CuttingActions action)
        {
            Action = action;
        }
    }

    enum CuttingActions
    {
        Idle,
        Cutting
    }
}
