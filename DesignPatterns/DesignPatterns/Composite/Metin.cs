using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Metin : Icerik
    {
        public string icerik;
        public Metin(string i)
        {
            icerik = i;
        }
        public void operation()
        {
            Console.WriteLine(icerik);
        }
        public void Add(Icerik i)
        {
            return;
        }

        public Icerik GetChild(int i)
        {
            return null;
        }

        public void Remove(Icerik i)
        {
            return;
        }
    }
}
