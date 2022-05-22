using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class Listeleme
    {
        public static void Listele(Aggregate a)
        {
            Iterator i = a.CreateIterator();
            for(i.First(); !i.IsDone(); i.Next())
            {
                Console.WriteLine(i.CurrentItem());
            }
        }
    }
}
