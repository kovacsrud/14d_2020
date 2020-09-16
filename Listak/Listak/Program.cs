using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //generikus típus, a listaelem típusa bármi lehet
            //nem kötött az elemszám
            List<int> szamok = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < rand.Next(25,36); i++)
            {
                szamok.Add(rand.Next(-100, 200));
            }

            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            
            szamok.Clear();

            Console.ReadKey();
        }
    }
}
