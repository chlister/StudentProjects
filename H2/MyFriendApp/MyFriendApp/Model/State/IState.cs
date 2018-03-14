using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFriendApp.Model.State
{
    public interface IState
    {
        void Feed();
        void Sleep();
        void TalkTo();
        
    }
}
