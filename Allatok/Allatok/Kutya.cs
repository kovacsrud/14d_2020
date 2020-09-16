using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok
{
    public class Kutya:Allat
    {
        private int marMagassag;

        public Kutya()
        {
            marMagassag = 1;
        }

        public Kutya(int marmagassag,string nev,int suly):base(nev,suly)
        {
            marMagassag = marmagassag;
        }
               

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Eszik()
        {
            //base.Eszik();
            Console.WriteLine("A kutya eszik.");
        }

        public override void Mozog()
        {
            //base.Mozog();
            Console.WriteLine("A kutya mozog");
        }

        public void Kapar()
        {
            Console.WriteLine("Kapar ez a haszontalan kutya");
        }
    }
}
