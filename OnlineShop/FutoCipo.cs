using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class FutoCipo : Termek
    {
        int cipomeret;
        public FutoCipo(string megnevezes, double ar, int cipomeret) : base(megnevezes, ar)
        {
            this.cipomeret = cipomeret;
        }

        public void kosarba(int prio)
        {
            base.kosarba(prio, $"A kosárba került egy {cipomeret} -es {Megnevezes}!");
        }
    }
}
