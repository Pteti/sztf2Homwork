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

        public Masszazs(string megnevezes, double ar, int prioritas, int idotartam) : base(megnevezes, ar, prioritas)
        {
            this.idotartam = idotartam;
        }

        public void kosarba()
        {
            base.kosarba($"A kosárba került egy {idotartam} perces {Megnevezes}!");
        }
    }
}
