using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class Yonetici : State
    {
        private Program program;
        public Yonetici(Program p)
        {
            program = p;
        }
        public void Handle()
        {
            throw new NotImplementedException();
        }
    }
}
