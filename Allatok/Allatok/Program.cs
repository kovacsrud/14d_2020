using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat("Ubul",26);
            Allat masikAllat = new Allat();


            //allat.SetNev("Ubul");

            Console.WriteLine(allat.GetNev());
            allat.Eszik();
            allat.Mozog();



            //allat.SetNev("Zénó");

            Console.WriteLine(masikAllat.GetNev());

            Kutya kutya = new Kutya();

            Console.WriteLine($"Kutya:{kutya.GetNev()}");

            kutya.Kapar();
            kutya.Ugat();
            kutya.Mozog();

            Kutya ujKutya = new Kutya(120, "Zénó", 56);
            ujKutya.Mozog();
            ujKutya.Eszik();

            Console.ReadKey();
        }
    }
}
