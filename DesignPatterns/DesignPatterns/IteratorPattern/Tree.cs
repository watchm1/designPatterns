using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class Tree : Aggregate
    {
        private int deger;
        public Tree sol;
        public Tree sag;

        public Tree(int _deger)
        {
            deger = _deger;
            sol = null;
            sag = null;

        }

        public int deger_al() { return deger; }
        public void solaEkle(Tree a) { sol = a;}
        public void sagaEkle(Tree b) { sag = b; }
        public override Iterator CreateIterator()
        {
            return new TreeIterator(this);
        }
    }
}
