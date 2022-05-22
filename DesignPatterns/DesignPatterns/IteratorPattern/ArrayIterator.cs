using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.IteratorPattern
{
    public class ArrayIterator : Iterator
    {
        private ArrayList array;
        private int number;
        public ArrayIterator(ArrayList _array)
        {
            array = _array;
            number = 0;
        }

        public override int CurrentItem()
        {
            return array.list[number];
        }

        public override void First()
        {
            number = 0;
        }

        public override bool IsDone()
        {
            return number == array.list.Count();
        }

        public override void Next()
        {
            number++;
        }
    }
}
