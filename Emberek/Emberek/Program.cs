using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo = new Sportolo("kajak", "Zénó", 180, 1999, 96);
            sportolo.Sportol();
            sportolo.Eszik();
            Console.WriteLine(sportolo.GetEletkor());


            Console.ReadKey();
        }
    }
}
