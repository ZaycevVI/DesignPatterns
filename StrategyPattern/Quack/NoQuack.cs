﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack() {}
    }
}
