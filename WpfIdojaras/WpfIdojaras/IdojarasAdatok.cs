using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfIdojaras
{
    public class IdojarasAdatok
    {
        private List<IdojarasAdat> idojarasadatok;

        public IdojarasAdatok(string fajl)
        {
            idojarasadatok = new List<IdojarasAdat>();
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    idojarasadatok.Add(
                        new IdojarasAdat
                        {
                            Ev=Convert.ToInt32(e[0]),
                            Honap= Convert.ToInt32(e[1]),
                            Nap= Convert.ToInt32(e[2]),
                            Ora= Convert.ToInt32(e[3]),
                            Homerseklet= Convert.ToDouble(e[4]),
                            Szelsebesseg= Convert.ToDouble(e[5]),
                            Paratartalom= Convert.ToDouble(e[6])
                        }
                        );
                    
                }
                Debug.WriteLine(idojarasadatok.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);               
            }
        }

        public List<int> GetEvek()
        {
            List<int> evek = new List<int>();

            var eveklookup = idojarasadatok.ToLookup(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var i in eveklookup)
            {
                evek.Add(i.Key);
            }


            return evek;
        }

        public IOrderedEnumerable<IdojarasAdat> GetAdatok(int ev)
        {
            //List<IdojarasAdat> adatok = new List<IdojarasAdat>();
            var adatok = idojarasadatok.FindAll(x => x.Ev == ev).OrderBy(x=>x.Honap).ThenBy(x=>x.Nap).ThenBy(x=>x.Ora);

            return adatok;
        }
    }
}
