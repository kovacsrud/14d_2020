using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    public abstract class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public int GetEletkor()
        {
            return 2020 - SzuletesiEv;
        }

        public abstract void Eszik();

        public abstract void Iszik();

        public abstract void Mozog();

    }
}
