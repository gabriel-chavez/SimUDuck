﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    public class Quack:IQuackBehavior
    {
        public object Quacking()
        {
            return "Quack";
        }
    }
}