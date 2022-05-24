using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Tanimsiz : State
    {
        private Program program;
        public Tanimsiz(Program p)
        {
            program = p;
        }
        public void Handle()
        {
            Console.WriteLine("1 kayıt ol");
            Console.WriteLine("2 giris yap");
            Console.WriteLine("3 yönetici girişi");

            program.Login();
        }
    }
}
