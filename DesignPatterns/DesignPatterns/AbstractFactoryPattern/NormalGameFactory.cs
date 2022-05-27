using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class NormalGameFactory : GameFactory
    {
        public override VirtualDoor CreateDoor()
        {
            return new NormalDoor();
        }

        public override VirtualRoom CreateRoom()
        {
            return new NormalRoom();   
        }

        public override VirtualGame NewGame()
        {
            return new NormalGame();
        }
    }
}
