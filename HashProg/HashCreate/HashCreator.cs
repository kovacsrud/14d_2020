using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HashCreate
{
    public enum HashType
    {
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512
    }
    public class HashCreator
    {
        //választás az algoritmusok között
        //választás a string és a fájl között
        public string CreateHash(HashType t,string szoveg)
        {
            string hash = "";

            if (t == HashType.MD5)
            {
                byte[] data;
                MD5CryptoServiceProvider hasher = new MD5CryptoServiceProvider();
                if (File.Exists(szoveg))
                {
                    data = File.ReadAllBytes(szoveg);


                } else
                {
                    data = new UTF8Encoding().GetBytes(szoveg);
                }

                hash = ByteToHash(hasher.ComputeHash(data));

            } 
            else if (t == HashType.SHA1)
            {
                SHA1CryptoServiceProvider hasher = new SHA1CryptoServiceProvider();
            }
            else if (t == HashType.SHA256)
            {
                SHA256CryptoServiceProvider hasher = new SHA256CryptoServiceProvider();

            } else if (t == HashType.SHA384)
            {
                SHA384CryptoServiceProvider hasher = new SHA384CryptoServiceProvider();

            } else
            {
                //SHA512
                SHA512CryptoServiceProvider hasher = new SHA512CryptoServiceProvider();
            }
            
            return hash;
        }

        private string ByteToHash(byte[] data)
        {
            StringBuilder hashString = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                hashString.Append(data[i].ToString("x2"));
            }

            return hashString.ToString();
        }
    }
}
