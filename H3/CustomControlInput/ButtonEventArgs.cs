using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlInput
{
    public class ButtonEventArgs<T> : EventArgs  
    {
        public T Button { get;}
        public ButtonEventArgs(T button)
        {
            Button = button;
        }
    }
}
