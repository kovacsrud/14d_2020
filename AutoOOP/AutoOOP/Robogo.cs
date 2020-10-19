using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOOP
{
    public class Robogo : Jarmu, IKisGepjarmu
    {
        private int maxSebesseg;

        public Robogo(int sebesseg, string rendszam,int maxsebesseg) : base(sebesseg, rendszam)
        {
            maxSebesseg = maxsebesseg;
        }

        public override bool GyorsHajtottE(int sebessegkorlat)
        {
            if (sebesseg>sebessegkorlat)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public bool HaladhatItt(int sebesseg)
        {
            if (maxSebesseg>sebesseg)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
