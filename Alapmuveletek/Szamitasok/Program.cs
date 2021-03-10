using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alapmuveletek;

namespace Szamitasok
{
    class Program
    {
        static void Main(string[] args)
        {
            Alapmuvelet alapmuveletek = new Alapmuvelet();

            Console.WriteLine($"100+100={alapmuveletek.Osszeadas(100,100)}");

            Console.ReadKey();
        }
    }
}
