using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok
{
    public class Allat
    {
        //Adattagok
        private string nev;
        private int suly;

        public Allat()
        {
            this.nev = "A";
            this.suly = 1;
        }


        public Allat(string nev,int suly)
        {
            this.nev = nev;
            this.suly = suly;
        }

        //Metódusok
        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        //public void SetNev(string nev)
        //{
        //    this.nev = nev;
        //}

        public string GetNev()
        {
            return nev;
        }
    }
}
