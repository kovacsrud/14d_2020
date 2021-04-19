using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVG
{
    public class GameData
    {
        private List<Game> games;
        public List<Game> Games { get { return games; }  }

        public GameData(string fajl,char hatarolo,int start=0)
        {
            games = new List<Game>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                games.Add(new Game(sorok[i],hatarolo));
            }
        }

        public List<string> GetPlatforms()
        {
            List<string> platforms = new List<string>();
            var platformLookup = games.ToLookup(x => x.Platform).OrderBy(x=>x.Key);

            foreach (var i in platformLookup)
            {
                platforms.Add(i.Key);
            }

            return platforms;

        }
    }
}
