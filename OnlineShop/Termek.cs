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

        public Termek(string megnevezes, double ar)
        {
            this.megnevezes = megnevezes;
            this.ar = ar;
            MegrendelhetoTarolo.fabaIllesztes(this);
        }
        public void arAlkudozas()
        {
            Random rnd = new Random();
            if (rnd.Next(0, 100) % 3 == 0)
            {
                Console.WriteLine("Najó, kapsz 10% -ot!");
                ar = ar * 0.9;
            } else
            {
                Console.WriteLine("Sajnos teljes árat kell fizetned érte!");
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

        public void kosarba(int prioritas,string szoveg)
        {
            this.prioritas = prioritas;

            if (vanElegPenz())
            {
                Console.WriteLine(szoveg);
                Felhasznalo.FennmaradoOsszegKeret -= (int)this.ar;
                Naplozo?.Invoke(this);
            } else
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
