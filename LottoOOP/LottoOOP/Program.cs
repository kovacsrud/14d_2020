using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //A cél, hogy a játék összes tevékenysége egy osztályban
            //legyen, itt a főprogramban csak minimális kódot akarunk
            //a játékkal kapcsolatban szerepeltetni
            LottoGame jatek = new LottoGame(5, 90);
            jatek.Tippeles();
            jatek.Sorsolas();
            jatek.Tipplista();
            jatek.NyeroSzamLista();
            Console.WriteLine($"Találat:{jatek.Talalatok()}");

            Console.ReadKey();
        }
    }
}
