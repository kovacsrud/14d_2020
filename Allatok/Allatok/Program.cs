using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat("Ubul",26);
            Allat masikAllat = new Allat();


            //allat.SetNev("Ubul");

            Console.WriteLine(allat.GetNev());
            allat.Eszik();
            allat.Mozog();



            //allat.SetNev("Zénó");

            Console.WriteLine(masikAllat.GetNev());


            Console.ReadKey();
        }
    }
}
