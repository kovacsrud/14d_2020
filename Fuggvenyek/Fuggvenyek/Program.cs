using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        public static void Kiir()
        {
            Console.WriteLine("Prog");
        }

        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        public static int Osszead(int a,int b)
        {
            return a + b;
        }

        public static double Osszead(double a, double b)
        {
            return a + b;
        }

        public static void ErtekSzerint(int a)
        {
            a = a * a;
        }

        public static void Cimszerint(ref int a)
        {
            a = a * a;
        }

        static void Main(string[] args)
        {
            //Függvény (alprogram)
            //Visszatérési értékkel vagy anélkül(void)
            //Függvény túlterhelés (overloading)
            //Érték és cím szerint kaphatnak paramétereket a
            //függvények


            Kiir();
            Kiir("Hello");
            var osszeg = Osszead(123, 456);
            Console.WriteLine(osszeg);
            Kiir(Osszead(12, 12).ToString());
            Console.WriteLine(Osszead(33, 56));

            int a = 3;
            ErtekSzerint(a);
            Console.WriteLine(a);
            Cimszerint(ref a);
            Console.WriteLine(a);
            
            //készítsen függvényt, amely a paraméterül
            //kapott tömb elemeit kíírja


            //készítsen visszatérési értékkel rendelkező
            //függvényt, amely egy szám tetszőleges
            //hatványát adja vissza

                        
        }
    }
}
