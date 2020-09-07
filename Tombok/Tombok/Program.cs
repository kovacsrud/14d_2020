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


            Console.ReadLine();
        }
    }
}
