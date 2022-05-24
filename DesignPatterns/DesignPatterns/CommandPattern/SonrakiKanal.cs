using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class SonrakiKanal : Command
    {
        private Televizyon tv;
        public SonrakiKanal(Televizyon t)
        {
            tv = t;
        }

        public void execute()
        {
            tv.nextChannel();
            Console.WriteLine("Geçerli kanal : " + tv.currentChannel());
        }
        public string toString()
        {
            return "Sonraki kanal";
        }
    }
}
