using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        public static void TombList(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
                //Debug.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Készítsen lottójátékot, amelyben adott mennyiségű számból
            //húzunk ki valamennyi nyerőszámot pl. 6 45-ből, 5 90-ből stb.
            //A felhasználónak legyen lehetősége ezeket beállítani, de azt 
            //ne engedjük hogy a tippek száma meghaladja a
            //nyerőszámok darabszámát
            // A program kérje be a játékos tippjeit, kétszer ugyanazt a számot
            //ne fogadja el!
            //Sorsoljon ki adott számú nyerőszámot
            //Határozza meg és írja ki a találatok számát

            Console.Write("Hány számot húzunk?");
            var szamDb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány számból húzunk?");
            var osszSzam = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();

            var tippek = new int[szamDb];
            var nyeroSzamok = new int[szamDb];
            var talalat = 0;

            do
            {
                talalat = 0;
                tippek = new int[szamDb];
                nyeroSzamok = new int[szamDb];

                //Tippek bekérése
                for (int i = 0; i < szamDb; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());
                while (temp<1 || temp>osszSzam || tippek.Contains(temp))
                {
                    Console.Write("Rossz tipp");
                    temp = Convert.ToInt32(Console.ReadLine());
                }

                tippek[i] = temp;

            }
            
            TombList(tippek);

            //Tippek bekérése
            for (int i = 0; i < szamDb; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }

                nyeroSzamok[i] = temp;

            }
            TombList(nyeroSzamok);

            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                } 
            }

            Console.WriteLine($"Találatok:{talalat}");

            Console.WriteLine("Még játék? (Y/N)");

            } while (Console.ReadKey(true).Key==ConsoleKey.Y);

            Console.ReadKey();
        }
    }
}
