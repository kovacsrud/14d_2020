using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asztal> asztalok = new List<Asztal>();
            List<Szekreny> szekrenyek = new List<Szekreny>();

            Szekreny szekreny1 = new Szekreny
            {
                Anyaga="fém",
                KulccsalZarhato=true,
                MaxMagassag=180,
                Suly=100,
                Uveges=true
            };

            szekrenyek.Add(szekreny1);

            szekrenyek.Add(new Szekreny {
                Anyaga="Fa",
                KulccsalZarhato=true,
                MaxMagassag=160,
                Suly=80,
                Uveges=true
            });

            Console.WriteLine($"Elemszám:{szekrenyek.Count}");

            var uveges = szekrenyek.FindAll(x => x.Uveges == true && x.Anyaga=="fém");

            foreach (var i in uveges)         
            {
                Console.WriteLine($"{i.Anyaga},{i.KulccsalZarhato},{i.MaxMagassag},{i.Suly},{i.Uveges}");
            }

            Console.ReadKey();
        }
    }
}
