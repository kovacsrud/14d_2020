using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutyak kutyak = new Kutyak("kutyak.csv");
            Kutyafajtak kutyafajtak = new Kutyafajtak("kutyafajtak.csv");
            Kutyanevek kutyanevek = new Kutyanevek("kutyanevek.csv");

            Console.WriteLine($"{kutyak.Kutyaadatok.Count}");

            var kutyaknevekkel = kutyak.Kutyaadatok.Join(kutyanevek.Kutyanevadatok,
                k => k.NevId,
                kn => kn.Id,
                (k, kn) => new {
                    Id = k.Id,
                    Kutyanev = kn.Kutyaneve,
                    FajtaId = k.FajtaId,
                    Eletkor = k.Eletkor,
                    UtolsoEll = k.UtolsoEll }
                );

            var teljes = kutyaknevekkel.Join(kutyafajtak.Kutyafajtaadatok,
                kn => kn.FajtaId,
                kf => kf.Id,
                (kn, kf) => new
                {
                    Id=kn.Id,
                    Kutyanev=kn.Kutyanev,
                    Kutyafajta=kf.Nev,
                    Kutyafajtaeredeti=kf.Eredetinev,
                    Eletkor=kn.Eletkor,
                    UtolsoEll=kn.UtolsoEll
                }
                );

            //foreach (var i in teljes)
            //{
            //    Console.WriteLine($"{i.Id},{i.Eletkor},{i.Kutyanev},{i.Kutyafajta}");
            //}

            var legidosebb = teljes.Where(x=>x.Eletkor==teljes.Max(y=>y.Eletkor));

            Console.WriteLine($"A legidősebb kutya:{legidosebb.ElementAt(0).Kutyanev},{legidosebb.ElementAt(0).Kutyafajta}");
            Console.WriteLine($"A legidősebb kutya:{legidosebb.First().Kutyanev},{legidosebb.First().Kutyafajta}");

            var januar = teljes.Where(x=>x.UtolsoEll=="2018.01.10");

            var fajtankent = januar.ToLookup(x=>x.Kutyafajta);

            foreach (var i in fajtankent)
            {
                Console.WriteLine($"{i.Key},{i.Count()} db");
            }

            Console.ReadKey();
        }
    }
}
