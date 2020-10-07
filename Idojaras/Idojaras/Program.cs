using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            IdojarasAdatok adatok = new IdojarasAdatok("idojaras.csv", true, ';');

            Console.WriteLine(adatok.IdoAdatok.Count);

            //Mely évek adatait tartalmazza a lista (első - utolsó)
            Console.WriteLine(adatok.IdoAdatok.Min(x => x.Ev));
            Console.WriteLine(adatok.IdoAdatok.Max(x => x.Ev));

            var ev2006 = adatok.IdoAdatok.FindAll(x=>x.Ev==2006);

            //foreach (var i in ev2006)
            //{
            //    Console.WriteLine($"{i.Ev}.{i.Honap}.{i.Nap}");
            //}
            //2006 első felének az átlaghőmérséklete?

            var atlag2006 = ev2006.FindAll(x => x.Honap >= 1 && x.Honap <= 6).Average(x=>x.Homerseklet);
            Console.WriteLine(atlag2006);

            //2006 legmelegebb napja?
            var legmelegebb = ev2006.Find(x=>x.Homerseklet==ev2006.Max(y=>y.Homerseklet));

            if (legmelegebb==null)
            {
                Console.WriteLine("Nincs ilyen");
            } else
            {
                Console.WriteLine($"{legmelegebb.Honap}.{legmelegebb.Nap}--{legmelegebb.Ora}");
            }

            //Összesítések készítése
            //Évenként hány sor adat szerepel a listában

            //var evenkenti = adatok.IdoAdatok.ToLookup(x=>x.Ev);
            var evenkenti = adatok.IdoAdatok.GroupBy(x =>new { x.Ev,x.Honap }).OrderBy(x=>x.Key.Ev).ThenBy(x=>x.Key.Honap).Where(x=>x.Key.Honap==4);

            

            foreach (var i in evenkenti)
            {
                Console.WriteLine($"{i.Key.Ev}-{i.Key.Honap},{i.Average(x=>x.Homerseklet)}");
                
            }



            Console.ReadKey();
        }
    }
}
