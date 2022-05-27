using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class VirtualDoor
    {
        public abstract bool OpenDoor();
        public abstract void CloseDoor();
    }
}
