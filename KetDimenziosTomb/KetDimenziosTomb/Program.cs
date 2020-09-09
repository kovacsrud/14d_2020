using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetDimenziosTomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] szamok = new int[20, 10];

            Random rand = new Random();

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    szamok[i, j] = rand.Next(-100, 101);
                }
            }






            Console.ReadKey();
        }
    }
}
