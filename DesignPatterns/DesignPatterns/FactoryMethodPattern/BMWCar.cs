using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    internal class BMWCar : Car
    {
        public BMWCar()
        {
            maxSpeed = 300;
            currentSpeed = 0;
        }
        public override int getMaxSpeed()
        {
            return maxSpeed;
        }

        public override string modal()
        {
            return "BMW";
        }

        public override void setSpeed(int _speed)
        {
            currentSpeed = _speed;
        }
    }
}
