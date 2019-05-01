using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public delegate void TermekRendelesNaplozo(Termek termek);
    public class Termek : IMegrendelheto, IComparable
    {
        string megnevezes;
        double ar;
        int prioritas;
        public TermekRendelesNaplozo Naplozo { get; set; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public double Ar { get => ar; set => ar = value; }
        public int Prioritas { get => prioritas; set => prioritas = value; }

        public Termek(string megnevezes, double ar, int prioritas)
        {
            this.megnevezes = megnevezes;
            this.ar = ar;
            this.prioritas = prioritas;
            MegrendelhetoTarolo.fabaIllesztes(this);
        }
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
                    return 3;
                default:
                    return 7;
            }
        }

        public void kosarba(string uzenet)
        {
            Console.WriteLine(uzenet);
            Naplozo?.Invoke(this);
        }
    }
}
