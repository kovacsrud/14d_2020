using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    public class Ember
    {
        

        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        private int kor;
        public int Kor {
            get { return kor; }
            set { kor = 2020-SzuletesiEv; }
        }


        public Ember()
        {

        }

        public Ember(string nev, int szuletesiEv, int magassag, int suly,int kor)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
            Magassag = magassag;
            Suly = suly;
            Kor = kor;
        }

        public override string ToString()
        {
            return $"Név:{Nev},Születési év:{SzuletesiEv},Magasság:{Magassag},Kor:{Kor},Súly:{Suly}";
        }





    }
}
