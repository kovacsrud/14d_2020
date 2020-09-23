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
            LottoGame masik = new LottoGame(7, 45);
            //jatek.Tippeles();
            //jatek.Sorsolas();
            //jatek.Tipplista();
            //jatek.NyeroSzamLista();
            //Console.WriteLine($"Találat:{jatek.Talalatok()}");
            jatek.Jatek();
            masik.Jatek();
           
            

            Console.ReadKey();
        }
    }
}
