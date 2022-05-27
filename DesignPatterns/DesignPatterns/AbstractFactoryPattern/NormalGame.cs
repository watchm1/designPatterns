using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class NormalGame : VirtualGame
    {
        List<VirtualRoom> rooms;
        public NormalGame()
        {
            rooms = new List<VirtualRoom>();
        }
        public override void AddRoom(VirtualRoom room)
        {
            rooms.Add(room);
        }

        public override void RunGame()
        {
            Console.WriteLine("Normal game already runnning");
            Console.WriteLine("Size of rooms :" + rooms.Count); 
        }
    }
}
