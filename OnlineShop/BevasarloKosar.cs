using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public static class BevasarloKosar
    {
        static LinkedList<IMegrendelheto> bevasarloKosar = new LinkedList<IMegrendelheto>();
        static int mezekSzama = 0;
        static int cipokSzama = 0;

        public static void kosarbaTesz(IMegrendelheto rendeles)
        {
            bevasarloKosar.AddLast(rendeles);
        }

        public static void termekRendelt(IMegrendelheto termek)
        {
            if (termek is Mez)
                mezekSzama += 1;
            else
                cipokSzama += 1;
        }

        public static void termekRendelesLekerdezes()
        {
            Console.WriteLine($"A megrendelt mezek szama: {mezekSzama} \nA megrendelt cipok szama: {cipokSzama}");
        }

        public static void rendelesLekerdezes()
        {
            foreach(var item in bevasarloKosar)
            {
                Console.WriteLine(item.Megnevezes);
            }
        }

        public static void Naploz(IMegrendelheto termek)
        {
            kosarbaTesz(termek);
            if (termek is Termek)
              {
                termekRendelt(termek);
              }
        }
    }
}
