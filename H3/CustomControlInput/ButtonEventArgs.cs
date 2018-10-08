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
    public enum FryButtons
    {
        B0,
        B1,
        B2
    }
    public enum PotButtons
    {
        B0,
        B1
    }
    public enum CuttingButtons
    {
        B0,
        B1,
        B2,
        B3
    }
    public enum AssemblerButtons
    {
        B0,
        B1
    }
}
