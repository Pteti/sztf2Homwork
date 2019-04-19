using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    interface IMegrendelheto
    {
        String Megnevezes
        {
            get;
            set;
        }

        double Ar
        {
            get;
            set;
        }

        int Prioritas
        {
            get;
            set;
        }

        int szallitasiIdoKiszamitasa(int tavolsag);

        void arAlkudozas();
    }
}
