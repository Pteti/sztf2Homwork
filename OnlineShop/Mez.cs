using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Mez : Termek
    {

        string ruhameret;

        public Mez(string megnevezes, double ar, int prioritas,string ruhameret) : base(megnevezes,ar,prioritas)
        {
            this.ruhameret = ruhameret;
        }

        public void kosarba()
        {
            base.kosarba($"A kosárba került egy {ruhameret} -es {Megnevezes}!");
        }
    }
}
