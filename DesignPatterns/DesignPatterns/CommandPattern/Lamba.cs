using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Lamba
    {
        private int lamb;
        public Lamba()
        {
            lamb = 0;
        }
        public void TurnOnLamba()
        {
            Console.WriteLine("The lamb open");
            lamb = 1;
        }
        public void TurnOffLamba()
        {
            Console.WriteLine("The lamb closed");
            lamb = 0;
        }
        public int ReturnValue() { return this.lamb;  }

    }
}
