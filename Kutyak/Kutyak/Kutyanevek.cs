using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyanevek
    {
        public class Kutyanev
        {
            public int Id { get; set; }
            
            public string Kutyaneve { get; set; }

        }
        private List<Kutyanev> kutyanevadatok;
        public List<Kutyanev> Kutyanevadatok { get; }

        public Kutyanevek(string fajl)
        {
            kutyanevadatok = new List<Kutyanev>();
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyanevadatok.Add(
                        new Kutyanev
                        {
                            Id = Convert.ToInt32(e[0]),
                            Kutyaneve = e[1]

                        }
                        );
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
