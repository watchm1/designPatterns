using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class ArrayList : Aggregate
    {
        public List<int> list;
        public ArrayList()
        {
            list = new List<int>();
            list.Add(0);
            list.Add(5);
            list.Add(1);
            list.Add(6);
            list.Add(7);
        }
        
        public override Iterator CreateIterator()
        {
            return new ArrayIterator(this);
        }
    }
}
