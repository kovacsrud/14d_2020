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
