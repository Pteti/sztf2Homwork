using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Masszazs : Szolgaltatas
    {
        int idotartam;

        public Masszazs(string megnevezes, double ar, int idotartam) : base(megnevezes, ar)
        {
            this.idotartam = idotartam;
        }

        public void kosarba(int prio)
        {
            base.kosarba(prio, $"A kosárba került egy {idotartam} perces {Megnevezes}!");
        }
    }
}
