using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Resim : Icerik
    {
        private string ImagePath;
        public Resim(string path)
        {
            ImagePath = path;
        }

        public void operation()
        {
            Console.WriteLine(ImagePath);
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
