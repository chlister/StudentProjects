using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlInput
{
public    class FryEventArgs : EventArgs
    {
        public FryState State { get; set; }
        public FryEventArgs(FryState state)
        {
            State = state;
        }
    }
    public enum FryState
    {
        FryOff,
        FryOn
    }
}
