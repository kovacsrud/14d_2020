using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyafajtak
    {
        public class Kutyafajta
        {
            public int Id { get; set; }

            public string Nev { get; set; }
            public string Eredetinev { get; set; }

        }
        private List<Kutyafajta> kutyafajtaadatok;
        public List<Kutyafajta> Kutyafajtaadatok { get { return kutyafajtaadatok; } }

        public Kutyafajtak(string fajl)
        {
            kutyafajtaadatok = new List<Kutyafajta>();
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyafajtaadatok.Add(
                        new Kutyafajta
                        {
                            Id = Convert.ToInt32(e[0]),
                            Nev = e[1],
                            Eredetinev=e[2]

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
