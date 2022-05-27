using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class MagicGame : VirtualGame
    {
        List<VirtualRoom> rooms;

        public MagicGame()
        {
            rooms = new List<VirtualRoom>();
        }
        public override void AddRoom(VirtualRoom room)
        {
            rooms.Add(room);
        }

        public override void RunGame()
        {
            Console.WriteLine("Magic game starting");
            if(rooms.Count > 0)
            {
                if (rooms[0].OpenDoor())
                {
                    Console.WriteLine("Door opened");
                }
                else
                {
                    Console.WriteLine("Door can't open");
                }
            }
        }
    }
}
