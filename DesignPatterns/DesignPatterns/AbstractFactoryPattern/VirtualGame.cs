using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class VirtualGame
    {
        public abstract void AddRoom(VirtualRoom room);
        public abstract void RunGame();
    }
}
