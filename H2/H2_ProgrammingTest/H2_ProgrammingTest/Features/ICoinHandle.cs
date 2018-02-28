using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_ProgrammingTest.Features
{
     interface ICoinHandle
    {
        int CurrentCoin { get; }
        int StockedCoin { get; }
        void InputCoin(int coin);
        int RetriveCoin();
    }
}
