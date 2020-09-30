using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    public class Nyugdijas : Ember
    {
        public int Munkaviszony { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas keveset eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A nyugdíjas sokat iszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog");
        }


    }
}
