using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class LamaAcKapa : Command
    {
        Lamba lamba;
        public LamaAcKapa(Lamba l)
        {
            lamba = l;
        }
        public void execute()
        {
            if (lamba.ReturnValue() == 1) lamba.TurnOffLamba();
            else lamba.TurnOnLamba();
        }
        public string toString()
        {
            if (lamba.ReturnValue() == 1) return "Lamba kapa";
            else return "LambaAç";
        }
    }
}
