using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public delegate void SzolgaltatasRendelesNaplozo(Szolgaltatas szolgaltatas);
    public class Szolgaltatas : IMegrendelheto, IComparable
    {
        string megnevezes;
        double ar;
        int prioritas;
        public SzolgaltatasRendelesNaplozo Naplozo { get; set; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public double Ar { get => ar; set => ar = value; }
        public int Prioritas { get => prioritas; set => prioritas = value; }

        public Szolgaltatas(string megnevezes, double ar)
        {
            this.megnevezes = megnevezes;
            this.ar = ar;
            MegrendelhetoTarolo.fabaIllesztes(this);
        }
        public int szallitasiIdoKiszamitasa(int tavolsag)
        {
            switch (tavolsag)
            {
                case var expression when tavolsag < 10:
                    return 1;
                default:
                    return 2;
            }
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

        public void kosarba(int prioritas, string szoveg)
        {
            this.prioritas = prioritas;

            if (vanElegPenz())
            {
                Console.WriteLine(szoveg);
                Felhasznalo.FennmaradoOsszegKeret -= (int)this.ar;
                Naplozo?.Invoke(this);
            }
            else
            {
                BevasarloKosar.prioritasRendezes(this);
            }
        }

        public bool vanElegPenz()
        {
            return this.ar < Felhasznalo.FennmaradoOsszegKeret;
        }
    }
}
