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
                //Console.WriteLine($"{reader.TokenType},{reader.ValueType},{reader.Value}");
                //Console.WriteLine($"{reader.Value}");
            }

            JObject colors = JObject.Parse(jsonFajl);

            Console.WriteLine(colors["colors"][0]["color"]);
            Console.WriteLine(colors["colors"][2]["color"]);
            Console.WriteLine(colors["colors"][3]["code"]["rgba"][0]);
            Console.WriteLine(colors["colors"][3]["code"]["hex"]);

            var jsColors = colors.SelectToken("colors");
            Console.WriteLine(jsColors[0]["color"]);


            Console.ReadKey();
        }
    }
}
