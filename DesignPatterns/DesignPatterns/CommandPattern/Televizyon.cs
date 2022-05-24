using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Televizyon
    {
        private int kanal;

        public Televizyon()
        {
            kanal = 1;
        }
        public void ChangeChannel(int k)
        {
            this.kanal = k;
        }
        public void nextChannel()
        {
            this.kanal++;
        }
        public void previousChannel()
        {
            this.kanal--;
        }
        public int currentChannel() { return this.kanal; }
    }
}
