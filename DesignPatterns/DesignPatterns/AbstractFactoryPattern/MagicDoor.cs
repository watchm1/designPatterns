using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal class MagicDoor : VirtualDoor
    {
        private string magicWord;
        private bool isOpen = false;
        public MagicDoor()
        {
            magicWord = "Open the gates";
            isOpen = false;
        }
        public override void CloseDoor()
        {
            isOpen = false;
        }

        public override bool OpenDoor()
        {
            if (isOpen) return true;
            Console.WriteLine("Magic word please...");
            string word = Convert.ToString(Console.ReadLine());
            if (word.Equals(magicWord))
            {
                isOpen = true;
                return isOpen;
            } 
            else return false;
            return isOpen;
        }
    }
}
