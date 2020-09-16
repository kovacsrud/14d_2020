using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ember = new Ember();

            ember.Kor = 26;
            ember.Nev = "Nagy Zénó";

            Ember masikEmber = new Ember("Elek", 1999, 180, 76, 21);

            Console.WriteLine(masikEmber.Nev);
            Console.WriteLine(masikEmber.SzuletesiEv);

            Console.ReadKey();
        }
    }
}
