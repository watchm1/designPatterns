using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Bolum : Icerik
    {
        private string baslik;
        private List<Icerik> icerikler;

        public Bolum(string b)
        {
            baslik = b;
            icerikler = new List<Icerik>();
        }
        public void operation()
        {
            Console.WriteLine(baslik);
            foreach(Icerik icerik in icerikler)
            {
                icerik.operation();
            }
        }
        public void Add(Icerik i)
        {
            icerikler.Add(i);
        }

        public Icerik GetChild(int i)
        {
            return icerikler[i];
        }

       

        public void Remove(Icerik i)
        {
            icerikler.Remove(i);
        }
    }
}
