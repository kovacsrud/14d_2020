using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOOP
{
    public class Orszagut
    {
        private List<Jarmu> jarmuvek;
        public List<Jarmu> Jarmuvek { get { return jarmuvek; } }

        public Orszagut(string fajl)
        {
            jarmuvek = new List<Jarmu>();
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    if (e[0]=="robogo")
                    {
                        Robogo robogo = new Robogo(
                            Convert.ToInt32(e[2]),
                            e[1],
                            Convert.ToInt32(e[3])
                            );
                        jarmuvek.Add(robogo);
                    }
                    else
                    {
                        AudiS8 audi = new AudiS8(
                            Convert.ToInt32(e[2]),
                            e[1],
                            Convert.ToBoolean(e[3])
                            );
                        jarmuvek.Add(audi);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            

        }
        
    }
}
