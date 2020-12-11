using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutyak kutyak = new Kutyak("kutyak.csv");
            Kutyafajtak kutyafajtak = new Kutyafajtak("kutyafajtak.csv");
            Kutyanevek kutyanevek = new Kutyanevek("kutyanevek.csv");




            Console.ReadKey();
        }
    }
}
