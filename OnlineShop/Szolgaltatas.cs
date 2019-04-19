using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Szolgaltatas : IMegrendelheto
    {
        string megnevezes;
        int ar;
        int prioritas;
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Prioritas { get => prioritas; set => prioritas = value; }

        public int arAlkudozas()
        {
            throw new NotImplementedException();
        }

        public int szallitasiIdoKiszamitasa(int tavolsag)
        {
            throw new NotImplementedException();
        }
    }
}
