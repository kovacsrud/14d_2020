using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEsOsztaly
{
    public class Szemely
    {
        

        public string VezetekNev { get; set; }
        public string Keresztnev { get; set; }
        public int SzuletesiEv { get; set; }
        public string SzuletesiHely { get; set; }

        public Szemely(string vezetekNev, string keresztnev, int szuletesiEv, string szuletesiHely)
        {
            VezetekNev = vezetekNev;
            Keresztnev = keresztnev;
            SzuletesiEv = szuletesiEv;
            SzuletesiHely = szuletesiHely;
        }


    }
}
