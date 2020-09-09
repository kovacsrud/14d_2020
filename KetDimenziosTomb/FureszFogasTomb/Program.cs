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

            furesz[0]=new int[] { 1,2,3,4,5};
            furesz[1] = new int[] { 11, 22, 33 };
            furesz[2] = new int[] { 33, 44, 55, 66 };
            furesz[3] = new int[] { 111, 222 };


            //kiíratás

            for (int i = 0; i < furesz.Length; i++)
            {
                for (int j = 0; j < furesz[i].Length; j++)
                {
                    Console.Write(furesz[i][j]+" ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
