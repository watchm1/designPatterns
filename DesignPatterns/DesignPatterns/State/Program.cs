using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Program
    {
        State s;
        public Program()
        {
            s = new Tanimsiz(this);
        }
        public void Calis()
        {
            s.Handle();
        }
        public void Login()
        {
            s = new Kullanici(this);
            Calis();
        }
        public void Yonetici()
        {
            s = new Yonetici(this);
            Calis();
        }
        public void Logout()
        {
            s = new Tanimsiz(this);
            Calis();
        }
    }
}
