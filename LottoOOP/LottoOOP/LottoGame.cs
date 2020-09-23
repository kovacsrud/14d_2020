using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class LottoGame
    {
        private int hanySzam;
        private int osszSzam;
        int[] tippek;
        int[] nyeroSzamok;
        int talalat;
        Random rand = new Random();

        public LottoGame(int hanyszam,int osszszam)
        {
            hanySzam = hanyszam;
            osszSzam = osszszam;
            tippek = new int[hanySzam];
            nyeroSzamok = new int[hanySzam];
            talalat = 0;

        }

        public void Tippeles()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write($"{i+1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());
                while (temp>osszSzam || temp<1 || tippek.Contains(temp))
                {
                    Console.Write($"Rossz!{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
                Debug.Write(tippek[i] + " ");
            }
            
        }

        public void Sorsolas()
        {
            for (int i = 0; i < nyeroSzamok.Length; i++)
            {
                var temp = rand.Next(1, osszSzam + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
                Debug.Write(nyeroSzamok[i] + " ");
            }


        }

        public int Talalatok()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }
            return talalat;
        }

        private void Lista(int[] tomb)
        {
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        public void Tipplista()
        {
            Lista(tippek);
        }

        public void NyeroSzamLista()
        {
            Lista(nyeroSzamok);
        }




    }
}
