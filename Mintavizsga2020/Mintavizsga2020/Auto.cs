using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mintavizsga2020
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int Evjarat { get; set; }
        public string Uzem { get; set; }
        public int Hengerurtartalom { get; set; }
        public int Teljesitmeny { get; set; }
        public int FutottKm { get; set; }
        public int Ar { get; set; }

        public Auto(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Id = Convert.ToInt32(e[0]);
            Marka = e[1];
            Tipus = e[2];
            Evjarat= Convert.ToInt32(e[3]);
            Uzem = e[4];
            Hengerurtartalom= Convert.ToInt32(e[5]);
            Teljesitmeny= Convert.ToInt32(e[6]);
            FutottKm= Convert.ToInt32(e[7]);
            Ar= Convert.ToInt32(e[8]);

        }

        public Auto(int id, string marka, string tipus, int evjarat, string uzem, int hengerurtartalom, int teljesitmeny, int futottKm, int ar)
        {
            Id = id;
            Marka = marka;
            Tipus = tipus;
            Evjarat = evjarat;
            Uzem = uzem;
            Hengerurtartalom = hengerurtartalom;
            Teljesitmeny = teljesitmeny;
            FutottKm = futottKm;
            Ar = ar;
        }
    }
}
