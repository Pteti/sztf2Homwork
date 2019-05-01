using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Ujsagelofizetes : Szolgaltatas
    {
        int honapszam;

        public Ujsagelofizetes(string megnevezes, double ar, int prioritas, int honapszam) : base(megnevezes, ar, prioritas)
        {
            this.honapszam = honapszam;
        }

        public void kosarba()
        {
            base.kosarba($"A kosárba került egy {honapszam} -os {Megnevezes}!");
        }
    }
}
