using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class MagicGameFactory : GameFactory
    {
        public override VirtualDoor CreateDoor()
        {
            return new MagicDoor();
        }

        public override VirtualRoom CreateRoom()
        {
            return new MagicRoom();
        }

        public override VirtualGame NewGame()
        {
            return new MagicGame();
        }
    }
}
