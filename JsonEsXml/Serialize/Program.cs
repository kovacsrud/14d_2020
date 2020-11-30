using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToplistaElem> toplista = new List<ToplistaElem>();
            toplista.Add(new ToplistaElem {Nev="Destroyer",Pontszam=2677 });
            toplista.Add(new ToplistaElem { Nev = "Fatality", Pontszam = 2388 });
            toplista.Add(new ToplistaElem { Nev = "NoPingJustLag", Pontszam = 2188 });
            toplista.Add(new ToplistaElem { Nev = "Noob", Pontszam = 1988 });

            //Szerializáció XML fájlokkal
            var xmlFajl = "toplista.xml";
            var serializer = new XmlSerializer(typeof(List<ToplistaElem>));
            using (var fs = new FileStream(xmlFajl, FileMode.Create))
            {
                serializer.Serialize(fs, toplista);
            }

            List<ToplistaElem> betolt;
            using (var fs=new FileStream(xmlFajl,FileMode.Open))
            {
                betolt = (List<ToplistaElem>)serializer.Deserialize(fs);
            }

            foreach (var i in betolt)
            {
                Console.WriteLine($"{i.Nev},{i.Pontszam}");
            }


            Console.ReadKey();
        }
    }
}
