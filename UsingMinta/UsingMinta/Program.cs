using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UsingMinta
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {

                using (var bitmap = new Bitmap(1280, 1024))
                {

                    Console.WriteLine(GC.GetTotalMemory(false));
                }

            }

            Console.ReadKey();
        }
    }
}
