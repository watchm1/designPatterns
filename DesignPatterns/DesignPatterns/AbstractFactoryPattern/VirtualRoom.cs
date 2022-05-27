using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class VirtualRoom
    {
        public abstract void AddDoor(VirtualDoor d);
        public abstract bool OpenDoor();
    }
}
