using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class NormalDoor : VirtualDoor
    {
        private bool isOpen = false;
        public override void CloseDoor()
        {
            isOpen = false;
        }

        public override bool OpenDoor()
        {
            isOpen = true;
            return isOpen;
        }
    }
}
