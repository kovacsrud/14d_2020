using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            IdojarasAdatok adatok = new IdojarasAdatok("idojaras.csv", true, ';');

            Console.WriteLine(adatok.IdoAdatok.Count);




            Console.ReadKey();
        }
    }
}
