using System;
using DesignPatterns.IteratorPattern;
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Listeleme.Listele(new ArrayList());
            Tree agac = new Tree(1);
            Tree sol = new Tree(2);
            Tree sag = new Tree(3);
            Tree sag2 = new Tree(4);
            agac.solaEkle(sol);
            agac.sagaEkle(sag);
            agac.sagaEkle(sag2);

            Listeleme.Listele(agac);
        }

    }
}