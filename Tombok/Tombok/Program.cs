using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 2, 3, 4, 5 };
            var szamok2 = szamok;

            szamok2[0] = 10;

            //szamok[0] ??????

            Console.WriteLine($"Szamok:{szamok[0]},Szamok2:{szamok2[0]}");

            int[] szazas = new int[100];


            //töltsük fel -100, 100 közötti véletlen számmal

            Random rand = new Random();

            for (int i = 0; i < szazas.Length; i++)
            {
                szazas[i] = rand.Next(-100, 100 + 1);
            }

            TombLista(szazas);

            int db = 0;

            for (int i = 0; i < szazas.Length; i++)
            {
                if (szazas[i]>0)
                {
                    db++;

                    //Ha összeget gyűjtöttünk volna...
                    //db=db+szazas[i];
                    //db+=szazas[i];
                }
            }

            //Min, max

            Console.WriteLine($"{db} darab pozitív érték van.");

            int min = szazas[0];
            int max = szazas[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szazas[i]<min)
                {
                    min = szazas[i];
                }

                if (szazas[i]>max)
                {
                    max = szazas[i];
                }
            }

            Console.WriteLine($"Min:{min},Max:{max}");

            var be = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szazas.Length; i++)
            {
                if (be==szazas[i])
                {
                    Console.WriteLine("Az érték benne van!");
                    break;
                }
            }


            Console.WriteLine($"A tömbelemek összege:{szazas.Sum()},{szazas.Average()}");

            var benne=szazas.Contains(be);
            

            Console.ReadLine();
        }

        private static void TombLista(int[] szazas)
        {
            for (int i = 0; i < szazas.Length; i++)
            {
                Console.WriteLine(szazas[i]);
            }
        }
    }
}
