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

            var eveklookup = idojarasadatok.ToLookup(x=>x.Ev);

            foreach (var i in eveklookup)
            {
                evek.Add(i.Key);
            }


            return evek;
        }
    }
}
