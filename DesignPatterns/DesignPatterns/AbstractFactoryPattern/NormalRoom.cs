using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class NormalRoom : VirtualRoom
    {
        VirtualDoor door;
        public override void AddDoor(VirtualDoor d)
        {
            door = d;
        }

        public override bool OpenDoor()
        {
            return door.OpenDoor();
        }
    }
}
