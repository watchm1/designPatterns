using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public interface Icerik
    {
        void operation();
        void Add(Icerik i);
        void Remove(Icerik i);
        Icerik GetChild(int i);
    }
}
