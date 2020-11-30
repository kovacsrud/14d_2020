using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace JsonEsXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFajl = "";
            try
            {
                jsonFajl = File.ReadAllText("colors.json",Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            //Console.WriteLine(jsonFajl);
            JsonTextReader reader = new JsonTextReader(new StringReader(jsonFajl));

            while (reader.Read())
            {
                Console.WriteLine($"{reader.TokenType},{reader.ValueType},{reader.Value}");
            }


            Console.ReadKey();
        }
    }
}
