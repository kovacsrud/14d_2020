using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ismétlés");
            //Változók 
            //A változó a memória egy névvel ellátott része

            //egész típusok
            int a = -120;
            uint b = 120;
            long c = 1000000;
            byte d = 122;
            short e = 34;

            //lebegőpontos számok
            float fl = 10.12345678998765432f;
            double db = 10.12345678998765432;
            decimal dec = 10.1234567899876543212345678987654321m;

            //Console.WriteLine({0},{1},{2},fl);

            Console.WriteLine($"Fl:{fl},Db:{db},Dec{dec}");

            // var használata
            var valami = 1.123;


            //Szövegek
            //nem lehet megváltoztatni
            string szov = "Valami szöveg";

            //for (int i = 0; i < szov.Length; i++)
            //{
            //    Console.WriteLine(szov[i]);
            //}

            //Karakteres változó
            char kar = 'p';

            //Logikai értékek tárolása
            bool logikai = true;









            Console.ReadKey();

        }
    }
}
