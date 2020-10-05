using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeszek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tudunk-e különböző osztályú objektumot
            //azonos listában tárolni?
            List<ISikidom> sikidomok = new List<ISikidom>();

            Kor kor1 = new Kor(12);
            Kor kor2 = new Kor(36);
            Kor kor3 = new Kor(8.37);

            sikidomok.Add(kor1);
            sikidomok.Add(kor2);
            sikidomok.Add(kor3);

            Teglalap t1 = new Teglalap(12, 36);
            Teglalap t2 = new Teglalap(33.19, 36.69);
            Teglalap t3 = new Teglalap(21, 41);

            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);

            Console.WriteLine($"Összes kerület:{sikidomok.Sum(x=>x.Kerulet())}");
            Console.WriteLine($"Összes terület:{sikidomok.Sum(x => x.Terulet())}");

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Kor))
                {
                    Console.WriteLine("Ez kör");
                }
                if (i.GetType()==typeof(Teglalap))
                {
                    Console.WriteLine("Ez téglalap");
                }
            }

            //Írassuk ki csak a körök területét
            var korkerulet = sikidomok.Where(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());

            Console.WriteLine($"Körök kerülete:{korkerulet}");


            Console.ReadKey();
        }
    }
}
