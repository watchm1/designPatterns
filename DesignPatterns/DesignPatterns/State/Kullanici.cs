using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Kullanici : State
    {
        private Program program;
        public Kullanici(Program p)
        {
            program = p;
        }
        public void Handle()
        {
            throw new NotImplementedException();
        }
    }
}
