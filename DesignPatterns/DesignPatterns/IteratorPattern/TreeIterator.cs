using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class TreeIterator : Iterator
    {
        Tree basla;
        Tree guncel;
        Stack<Tree> yigin;
        
        public TreeIterator(Tree a)
        {
            basla = a;
            yigin = new Stack<Tree>();

        }
        public override int CurrentItem()
        {
            guncel = yigin.Pop();
            return guncel.deger_al();
        }

        public override void First()
        {
            guncel = basla;
            yigin = new Stack<Tree>();
            yigin.Push(guncel);
        }

        public override bool IsDone()
        {
            if (yigin == null) return true;
            else return false;
        }

        public override void Next()
        {
            if(guncel.sol != null) yigin.Push(guncel.sol);
            if (guncel.sag != null) yigin.Push(guncel.sag);
        }

    }
}
