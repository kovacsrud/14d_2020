using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmuvek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Munkagep> munkagepek = new List<Munkagep>();
            List<Szemelyszall> szemszallitok = new List<Szemelyszall>();
            
            Munkagep munkagep = new Munkagep {
                Alkalmazas="markoló",
                Eroforras="diesel",
                Hossz=6,
                IsKozforgalom=true,
                MaxSebesseg=25,
                Teljesitmeny=250,
                Tomeg=5000
            };

            Munkagep munkagep2 = new Munkagep
            {
                Alkalmazas = "talajgyalu",
                Eroforras = "diesel",
                Hossz = 10,
                IsKozforgalom = true,
                MaxSebesseg = 15,
                Teljesitmeny = 350,
                Tomeg = 6000
            };

            munkagepek.Add(munkagep);
            munkagepek.Add(munkagep2);

            Szemelyszall szemsz = new Szemelyszall {
                Alvazszam=1001,
                Motorszam=110111,
                Eroforras="benzin",
                Hossz=3,
                MaxSebesseg=180,
                SzallSzem=5,
                Teljesitmeny=180,
                Tomeg=1800
            };

            Szemelyszall szemsz2 = new Szemelyszall
            {
                Alvazszam = 1001455,
                Motorszam = 11014431,
                Eroforras = "benzin",
                Hossz = 2.5,
                MaxSebesseg = 160,
                SzallSzem = 4,
                Teljesitmeny = 80,
                Tomeg = 1100
            };

            szemszallitok.Add(szemsz);
            szemszallitok.Add(szemsz2);






            Console.ReadKey();
        }
    }
}
