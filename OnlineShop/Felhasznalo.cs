using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    static class Felhasznalo
    {
        static string nev;
        static int osszegkeret;
        static int fennmaradoOsszeg;
        public static string Nev { get => nev; set => nev = value; }
        public static int Osszegkeret { get => osszegkeret; set => osszegkeret = value; }
        public static int FennmaradoOsszegKeret { get => fennmaradoOsszeg; set => fennmaradoOsszeg = value; }
    }
}
