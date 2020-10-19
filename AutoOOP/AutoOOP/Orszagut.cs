using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOOP
{
    public class Orszagut
    {
        private List<Jarmu> jarmuvek;
        public List<Jarmu> Jarmuvek { get { return jarmuvek; } }

        public Orszagut(string fajl)
        {
            jarmuvek = new List<Jarmu>();

        }
        
    }
}
