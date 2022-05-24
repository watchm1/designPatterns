using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class OncekiKanal : Command
    {
        private Televizyon tv;
        public OncekiKanal(Televizyon t)
        {
            tv = t;
        }
        public void execute()
        {
            tv.previousChannel();
            Console.WriteLine("Geçerli kanal" + tv.currentChannel());
        }
        public string toString()
        {
            return "Onceki kanal";
        }
    }
}
