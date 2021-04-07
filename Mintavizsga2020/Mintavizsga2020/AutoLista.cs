using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mintavizsga2020
{
    public class AutoLista
    {
        private List<Auto> autok;
        public List<Auto> Autok
        {
            get { return autok; }
        }

        public AutoLista(string fajl,char hatarolo,int start=0)
        {
            autok = new List<Auto>();
            try
            {
                var sorok = File.ReadAllLines(fajl,Encoding.Default);
                for (int i = start; i < sorok.Length; i++)
                {
                    autok.Add(new Auto(sorok[i],hatarolo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        public void HozzaadAuto(Auto auto)
        {
            autok.Add(auto);
        }

    }
}
