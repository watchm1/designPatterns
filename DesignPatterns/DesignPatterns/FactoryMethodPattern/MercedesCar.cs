using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class MercedesCar : Car
    {
        public MercedesCar()
        {
            maxSpeed = 290;
            currentSpeed = 0;
        }
        public override int getMaxSpeed()
        {
            return maxSpeed;
        }

        public override string modal()
        {
            return "MERCEDES";
        }

        public override void setSpeed(int _speed)
        {
            currentSpeed = _speed;
        }
    }
}
