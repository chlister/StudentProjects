using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlInput
{
    public class PotEventArgs : EventArgs
    {
        public PotState State { get; set; }
        public PotEventArgs(PotState state)
        {
            State = state;
        }
    }
    public enum PotState
    {
        LidOn,
        LidOff
    }
}
