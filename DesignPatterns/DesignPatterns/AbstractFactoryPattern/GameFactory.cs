using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    public abstract class GameFactory
    {
        public abstract VirtualGame NewGame();
        public abstract VirtualDoor CreateDoor();
        public abstract VirtualRoom CreateRoom();
    
    }
}
