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

        public Ujsagelofizetes(string megnevezes, double ar, int honapszam) : base(megnevezes, ar)
        {
            this.honapszam = honapszam;
        }

        public void kosarba(int prio)
        {
            base.kosarba(prio, $"A kosárba került egy {honapszam} -os {Megnevezes}!");
        }
    }
}
