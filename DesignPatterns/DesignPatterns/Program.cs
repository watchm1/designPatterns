using System;
using DesignPatterns.IteratorPattern;
using DesignPatterns.Composite;
using DesignPatterns.CommandPattern;
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////ITERATOR///////////
            //    Listeleme.Listele(new ArrayList());
            //    Tree agac = new Tree(1);
            //    Tree sol = new Tree(2);
            //    Tree sag = new Tree(3);
            //    Tree sag2 = new Tree(4);
            //    agac.solaEkle(sol);
            //    agac.sagaEkle(sag);
            //    agac.sagaEkle(sag2);

            //    Listeleme.Listele(agac);
            /////////////// COMPOSITE ///////////////

            //Bolum kitap = new Bolum("Progamlamaya giriş");
            //Bolum b1 = new Bolum("GİRİŞ");
            //b1.Add(new Metin("Hello, world"));
            //b1.Add(new Metin("Diğer programlar"));
            //Bolum b12 = new Bolum("Temel Programlama");
            //b12.Add(new Metin("Değişkenler"));
            //b12.Add(new Metin("Kontrol"));
            //b12.Add(new Metin("Döngüler"));

            //b1.Add(b12);

            //Bolum b2 = new Bolum("Değişkenler");
            //b2.Add(new Resim("değişken.jpg"));
            //b2.Add(new Metin("int, double, float, boolean"));

            //kitap.Add(b1);
            //kitap.Add(b2);


            //kitap.operation();
            //Console.WriteLine();
            //b12.operation();
            ////////////// COMMAND /////////////

            Menu m = new Menu();
            LamaAcKapa komut_lamba = new LamaAcKapa(new Lamba());
            Televizyon tv = new Televizyon();
            OncekiKanal komut_once = new OncekiKanal(tv);
            SonrakiKanal komut_sonra = new SonrakiKanal(tv);

            m.AddCommand(komut_lamba);
            m.AddCommand(komut_once);
            m.AddCommand(komut_sonra);


            m.MenuSystem();




        }

    }
}