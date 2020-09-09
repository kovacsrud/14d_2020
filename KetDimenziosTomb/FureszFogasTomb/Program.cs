using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FureszFogasTomb
{
    class Program
    {
        static void Main(string[] args)
        {

            //Jagged array, avagy fűrészfogas tömb
            //olyan tömb ahol a tömbelemek tömbök

            int[][] furesz = new int[4][];
            Random rand = new Random();

            furesz[0]=new int[] { 1,2,3,4,5};
            furesz[1] = new int[] { 11, 22, 33 };
            furesz[2] = new int[] { 33, 44, 55, 66 };
            furesz[3] = new int[] { 111, 222 };


           // kiíratás
            //for (int i = 0; i < furesz.Length; i++)
            //{
            //    for (int j = 0; j < furesz[i].Length; j++)
            //    {
            //        Console.Write(furesz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Hozzon létre egy új jagged tömböt, ahol az elemek
            //száma véletlenszerű, 1-5 közötti érték
            //A tömbelemekbe kerülő tömbök elemszáma is legyen 1-5 közötti
            //véletlenszerű érték
            //A tömbelemekbe kerülő értékek -10 - +20 közötti értékek legyenek!

            int[][] rnd = new int[rand.Next(1, 5 + 1)][];

            for (int i = 0; i < rnd.Length; i++)
            {
                // A tömböt létre kell hozni
                rnd[i] = new int[rand.Next(1, 5 + 1)];

                for (int j = 0; j < rnd[i].Length; j++)
                {
                    rnd[i][j] = rand.Next(-10, 20 + 1);
                }
            }


            for (int i = 0; i < rnd.Length; i++)
            {

                for (int j = 0; j < rnd[i].Length; j++)
                {
                    Console.Write(rnd[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
