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

        public Mez(string megnevezes, double ar,string ruhameret) : base(megnevezes,ar)
        {
            this.ruhameret = ruhameret;
        }

        public void kosarba(int prio)
        {
            base.kosarba(prio, $"A kosárba került egy {ruhameret} -es {Megnevezes}!");
        }
    }
}
