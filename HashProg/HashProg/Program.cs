using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HashProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami szöveg";
            //22e67b691bcc1bb1c806364fb660294e
            byte[] szovegbytes = new UTF8Encoding().GetBytes(szoveg);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            var hash = md5.ComputeHash(szovegbytes);

            

            StringBuilder hashmd5 = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                hashmd5.Append(hash[i].ToString("x2"));
            }

            Console.WriteLine(hashmd5);

            byte[] fajladatok = File.ReadAllBytes("toyota.jpg");

            hash = md5.ComputeHash(fajladatok);

            StringBuilder hashfajlmd5 = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                hashfajlmd5.Append(hash[i].ToString("x2"));
            }
            //3c10c2eabdbda72710357ba04f8a2941
            Console.WriteLine(hashfajlmd5.ToString());

            Console.ReadKey();
        }
    }
}
