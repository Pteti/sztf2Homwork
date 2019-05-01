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
        public FutoCipo(string megnevezes, double ar, int prioritas, int cipomeret) : base(megnevezes, ar, prioritas)
        {
            this.cipomeret = cipomeret;
        }

        public void kosarba()
        {
            base.kosarba($"A kosárba került egy {cipomeret} -es {Megnevezes}!");
        }
    }
}
