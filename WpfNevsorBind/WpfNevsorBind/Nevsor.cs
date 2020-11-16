using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfNevsorBind
{
    public class Nevsor
    {
        private List<Nev> nevsor;
        public List<Nev> NevSor { get { return nevsor; }  }

        public Nevsor(string fajl)
        {
            nevsor = new List<Nev>();
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(',');
                    nevsor.Add(
                        new Nev
                        {
                            Vezeteknev=e[0],
                            Keresztnev=e[1],
                            SzuletesiEv=Convert.ToInt32(e[2]),
                            SzuletesiHely=e[3]
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }

        }

        public List<Nev> VezetekNevKereses(string keres)
        {
            var eredmeny = nevsor.FindAll(x=>x.Vezeteknev.ToLower().StartsWith(keres.ToLower()));
            return eredmeny;
        }
    }
}
