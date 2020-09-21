using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEsOsztaly
{
     public class MasikSzemely
    {
        public string VezetekNev { get; set; }
        public string Keresztnev { get; set; }
        public int SzuletesiEv { get; set; }
        public string SzuletesiHely { get; set; }
        string[] vezeteknevek = { "Kiss", "Nagy", "Kovács", "Kósa", "Kertész", "Csabai" };
        string[] keresztnevek = { "Éva", "Anna", "Helga", "János", "Géza", "Xavér" };
        string[] helyisegek = { "Gyula", "Békéscsaba", "Orosháza", "Szeged" };
        

        public MasikSzemely(Random rand)
        {
     
            VezetekNev = vezeteknevek[rand.Next(0, vezeteknevek.Length)];
            Keresztnev = keresztnevek[rand.Next(0, keresztnevek.Length)];
            SzuletesiEv = rand.Next(1950, 2018 + 1);
            SzuletesiHely = helyisegek[rand.Next(0, helyisegek.Length)];
        }
    }
}
