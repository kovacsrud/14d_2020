using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    public class Sportolo : Ember
    {
        public Sportolo(string sportag,string nev,int magassag,int szulev,int suly)
        {
            Sportag = sportag;
            Nev = nev;
            Magassag = magassag;
            SzuletesiEv = szulev;
            Suly = suly;
        }

        public string Sportag { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sokat iszik, alkoholt soha.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló lendületesen mozog");
        }

        public void Sportol()
        {
            Console.WriteLine($"A sportoló sportok:{Sportag}");
        }
    }
}
