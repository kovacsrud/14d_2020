using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEsOsztaly
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vezeteknevek = {"Kiss","Nagy","Kovács","Kósa","Kertész","Csabai" };
            string[] keresztnevek = { "Éva", "Anna", "Helga", "János", "Géza", "Xavér" };
            string[] helyisegek = { "Gyula", "Békéscsaba", "Orosháza", "Szeged" };

            List<Szemely> szemelyek = new List<Szemely>();
            Random rand = new Random();
            //Készítsen osztályt, mely a következő adatokat tárolja:
            //Vezetéknév 
            //Keresztnév
            //Születési év (1950-2018 között)
            //Születési hely
            //Az osztály felhasználásával készítsen adott számú listát, amelyben 
            //az adatok a megadott adatokból véletlenszerűen vannak generálva


            Console.Write("Mennyi adatot generáljak?");
            var darab = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < darab; i++)
            {
                Szemely szemely = new Szemely(
                    vezeteknevek[rand.Next(0,vezeteknevek.Length)],
                    keresztnevek[rand.Next(0, keresztnevek.Length)],
                    rand.Next(1950,2018+1),
                    helyisegek[rand.Next(0, helyisegek.Length)]
                    );
                szemelyek.Add(szemely);
            }


            Console.WriteLine($"Lista elemszáma:{szemelyek.Count}");

            //for (int i = 0; i < szemelyek.Count; i++)
            //{
            //    Console.WriteLine(szemelyek[i].Keresztnev);
            //}

            foreach (var i in szemelyek)
            {
                Console.WriteLine($"{i.VezetekNev} {i.Keresztnev},{i.SzuletesiEv},{i.SzuletesiHely}");
            }

            //Hogyan tudunk adatokat visszanyerni a listából?

            var csabai = szemelyek.Find(x=>x.VezetekNev.ToLower()=="Csabai".ToLower());

            Console.WriteLine($"{csabai.Keresztnev},{csabai.SzuletesiHely}");

            var csabaiak = szemelyek.FindAll(x=>x.VezetekNev.ToLower()=="Csabai".ToLower() && x.SzuletesiHely=="Szeged");


            foreach (var i in csabaiak)
            {
                Console.WriteLine($"{i.VezetekNev} {i.Keresztnev},{i.SzuletesiEv},{i.SzuletesiHely}");
            }

            //Az egyes nevekből hány darab szerepel?



            Console.ReadKey();
        }
    }
}
