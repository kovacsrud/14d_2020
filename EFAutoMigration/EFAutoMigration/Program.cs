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
            
            
            


            Auto auto = new Auto
            {
                Rendszam="AAA-111",
                Gyartmany="Opel",
                Tipus="Corsa",
                GyartasiEv=2006
                
            };

            autoadatok.autok.Add(auto);

            autoadatok.SaveChanges();

            Console.WriteLine("Kész!");

            Console.ReadKey();
        }
    }
}
