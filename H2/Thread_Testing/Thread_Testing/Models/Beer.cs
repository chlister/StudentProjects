﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Testing.Models
{
    public class Beer : Product
    {
        public override string ProdType { get; set; } = "Beer";
        internal Beer(string _name, int _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
