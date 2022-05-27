using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class BMWFactory : CarFactory
    {

        public override Car ProduceCar()
        {
            return new BMWCar();
        }
    }
}
