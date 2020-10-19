using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOOP
{
    public abstract class Jarmu
    {
        public int sebesseg;
        private string rendszam;

        public Jarmu(int sebesseg, string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorsHajtottE(int sebessegkorlat);

        public override string ToString()
        {
            return $"{this.rendszam}-{this.sebesseg} km/h";
        }
    }
}
