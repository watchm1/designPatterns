using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public abstract class Car
    {
        public int maxSpeed;
        public int currentSpeed;


        public abstract int getMaxSpeed();
        public abstract string modal();
        public abstract void setSpeed(int _speed);
    }
}
