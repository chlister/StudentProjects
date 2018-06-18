using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaRPG.Model.MechModel
{
    public class Arm : MechPart, IArm 
    {
        public Weapon Weapon { get; set; }

        public Arm(int _hp, string _partName) : base(_hp, _partName)
        {
        }

    }
}
