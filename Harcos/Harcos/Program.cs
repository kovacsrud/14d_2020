using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harcos
{
    class Program
    {
        static void Main(string[] args)
        {
            Harcos h1 = new Harcos("Yoda", 100, 50);
            Harcos h2 = new Harcos("Dookoo",100,30);
            while (!h1.Harcol(h2))
            {
                h1.Harcol(h2);
                Console.WriteLine(h1.ToString());
                Console.WriteLine(h2.ToString());
            }



            Console.ReadKey();
        }
    }
}
