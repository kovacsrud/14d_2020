using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcos
{
    public class Harcos
    {
        private string nev;
        private int eletero;
        private int harciero;

        public string Nev
        {
            get
            {
                return nev;
            }

           
        }

        public int Eletero
        {
            get
            {
                return eletero;
            }

            set
            {
                eletero = value;
            }
        }

        public int Harciero
        {
            get
            {
                return harciero;
            }
                     
        }

        public Harcos(string nev, int eletero, int harciero)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.harciero = harciero;
        }

        public override string ToString()
        {
            return $"Név:{this.nev},Életerő:{this.eletero},Harci erő:{this.harciero}";
        }

        public bool Harcol(Harcos ellenfel)
        {
            ellenfel.Eletero = ellenfel.Eletero - this.harciero;
            this.eletero = this.eletero - ellenfel.Harciero;
            if (this.eletero <= 0 || ellenfel.Eletero <= 0)
            {
                return true;
            }
            else {
                return false;
            }

        }
    }
}
