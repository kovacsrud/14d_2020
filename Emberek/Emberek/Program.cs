using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo = new Sportolo("kajak", "Zénó", 180, 1999, 96);
            sportolo.Sportol();
            sportolo.Eszik();
            Console.WriteLine(sportolo.GetEletkor());
            Nyugdijas nyugdijas = new Nyugdijas {
                Munkaviszony=40,
                Magassag=160,
                Nev="János",
                Suly=88,
                SzuletesiEv=1946
            };

            Auto auto = new Auto {
                Rendszam="ABV-123",
                GyartasiEv=2006,
                AlvazSzam="1ZF0000H67",
                MotorSzam="AQH1177888",
                SzallSzemSzam=5

            };

            

            Console.ReadKey();
        }
    }
}
