﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public abstract class CarFactory
    {
        public abstract Car ProduceCar();
    }
}
