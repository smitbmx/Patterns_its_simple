﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Cat : AnimalToy
    {
        protected Cat(string name)
            : base(name)
        {

        }
    }
}
