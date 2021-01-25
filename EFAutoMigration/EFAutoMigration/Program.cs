using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAutoMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoadatok = new AutoContext();

            List<Auto> autok = new List<Auto>();          


            Auto auto = new Auto
            {
                Rendszam="AAA-112",
                Gyartmany="Opel",
                Tipus="Corsa",
                GyartasiEv=2006
                
            };

            autok.Add(auto);

            Tulaj tulaj = new Tulaj
            {
                Autok=autok,
                Nev="Kiss Ubul"
            };

            autoadatok.tulajok.Add(tulaj);

            autoadatok.SaveChanges();

            Console.WriteLine("Kész!");

            Console.ReadKey();
        }
    }
}
