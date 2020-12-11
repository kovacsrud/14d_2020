using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyak
    {
        public class Kutya
        {
            public int Id { get; set; }
            public int FajtaId { get; set; }
            public int NevId { get; set; }
            public  int Eletkor { get; set; }
            public string UtolsoEll { get; set; }

        }
        private List<Kutya> kutyaadatok;
        public List<Kutya> Kutyaadatok { get; }

        public Kutyak(string fajl)
        {
            kutyaadatok = new List<Kutya>();
            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
