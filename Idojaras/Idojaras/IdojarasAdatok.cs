using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    public class IdojarasAdatok
    {
        private List<IdojarasAdat> idoadatok;
        public List<IdojarasAdat> IdoAdatok {
            get { return idoadatok; }
        }

        public IdojarasAdatok(string fajl,bool isElsosor,char hatarolo)
        {
            idoadatok = new List<IdojarasAdat>();
            try
            {
                var sorok = File.ReadAllLines(fajl);
                var kezdosor = 0;
                if (isElsosor)
                {
                    kezdosor = 1;
                }
                for (int i = kezdosor; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(hatarolo);
                    idoadatok.Add(
                        new IdojarasAdat
                        {
                            Ev=Convert.ToInt32(e[0]),
                            Honap= Convert.ToInt32(e[1]),
                            Nap=Convert.ToInt32(e[2]),
                            Ora= Convert.ToInt32(e[3]),
                            Homerseklet=Convert.ToDouble(e[4]),
                            Szelsebesseg= Convert.ToDouble(e[5]),
                            Paratartalom= Convert.ToDouble(e[6])
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
