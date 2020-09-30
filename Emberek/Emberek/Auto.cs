namespace Emberek
{
    public class Auto
    {
        public Auto(string alvazSzam, int gyartasiEv, string motorSzam, string rendszam, int szallSzemSzam)
        {
            AlvazSzam = alvazSzam;
            GyartasiEv = gyartasiEv;
            MotorSzam = motorSzam;
            Rendszam = rendszam;
            SzallSzemSzam = szallSzemSzam;
        }

        public Auto()
        {

        }

        public string AlvazSzam { get; set; }
        public int GyartasiEv { get; set; }
        public string MotorSzam { get; set; }
        public string Rendszam { get; set; }
        public int SzallSzemSzam { get; set; }
    }
}