using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRHash;
namespace DllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHash hash = new CreateHash();
            Console.WriteLine(hash.MakeHash(HashType.SHA1,"valami"));
            Console.ReadKey();
        }
    }
}
