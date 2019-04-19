using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Termek : IMegrendelheto
    {
        string megnevezes;
        double ar;
        int prioritas;
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public double Ar { get => ar; set => ar = value; }
        public int Prioritas { get => prioritas; set => prioritas = value; }

        public void arAlkudozas()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) % prioritas == 0)
            {
                Console.WriteLine("Najó, kapsz 10% -ot!");
                ar = ar * 0.9;
            }
        }

        public int szallitasiIdoKiszamitasa(int tavolsag)
        {
            switch (tavolsag)
            {
                case var expression when tavolsag < 10:
                    return 10;
                default:
                    break;
            }
        }
    }
}
