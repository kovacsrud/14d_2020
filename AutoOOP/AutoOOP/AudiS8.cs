using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOOP
{
    public class AudiS8:Jarmu
    {
        private bool lezerblokkolo;

        public AudiS8(int sebesseg, string rendszam,bool lezerblokkolo) : base(sebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public override bool GyorsHajtottE(int sebessegkorlat)
        {
            throw new NotImplementedException();
        }
    }
}
