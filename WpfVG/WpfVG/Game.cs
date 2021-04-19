using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVG
{
    public class Game
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }

        public double NAsales { get; set; }
        public double EUsales { get; set; }
        public double JPsales { get; set; }
        public double Othersales { get; set; }
        public double Globalsales { get; set; }

        public Game(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Rank = Convert.ToInt32(e[0]);
            Name = e[1];
            Platform = e[2];
            Year = e[3];
            Genre = e[4];
            Publisher = e[5];
            NAsales = Convert.ToDouble(e[6]);
            EUsales= Convert.ToDouble(e[7]);
            JPsales= Convert.ToDouble(e[8]);
            Othersales= Convert.ToDouble(e[9]);
            Globalsales = Convert.ToDouble(e[10]);
        }

    }
}
