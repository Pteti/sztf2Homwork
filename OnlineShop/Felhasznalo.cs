using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Felhasznalo
    {
        string nev;
        int osszegkeret;
        public string Nev { get => nev; set => nev = value; }
        public int Osszegkeret { get => osszegkeret; set => osszegkeret = value; }
        public Felhasznalo()
        {
            Console.Write("Kerem adja meg a nevet: ");
            this.nev = Console.ReadLine();
            Console.Write("Kerem adja meg az osszegkeretet: ");
            this.osszegkeret = Convert.ToInt32(Console.ReadLine());
        }
    }
}
