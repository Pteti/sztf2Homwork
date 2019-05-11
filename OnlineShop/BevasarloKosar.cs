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
        static int legmagasabbPrioritas;
        static bool[] legjobbMegrendelheto;
            

        public static void kosarbaTesz(IMegrendelheto rendeles)
        {
            bevasarloKosar.AddLast(rendeles);
        }

        public static void kosarUrites()
        {
            bevasarloKosar.Clear();
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
            Console.WriteLine($"A fennmaradő kereted: {Felhasznalo.FennmaradoOsszegKeret}");
            kosarbaTesz(termek);
            if (termek is Termek)
              {
                termekRendelt(termek);
              }
        }

        public static void Backpack(List<IMegrendelheto> lista, bool[] valasztott, int melyseg, int ar, 
            int prioritas, int fennmaradoPrioritas)
        {
            if (ar > Felhasznalo.FennmaradoOsszegKeret) { return; }
            if (prioritas + fennmaradoPrioritas < legmagasabbPrioritas) { return; }
            if (melyseg == valasztott.Length)
            {
                legmagasabbPrioritas = prioritas;
                Array.Copy(valasztott, legjobbMegrendelheto, valasztott.Length);
                return;
            }

            fennmaradoPrioritas -= lista[melyseg].Prioritas;
            valasztott[melyseg] = false;

            Backpack(lista, valasztott, melyseg + 1, ar, prioritas, fennmaradoPrioritas);

            valasztott[melyseg] = true;
            ar += (int)lista[melyseg].Ar;
            prioritas += lista[melyseg].Prioritas;

            Backpack(lista, valasztott, melyseg + 1, ar, prioritas, fennmaradoPrioritas);
        }

        public static void prioritasRendezes(IMegrendelheto megrendelheto)
        {
            Console.WriteLine("Ez a termek nem fer bele a keretedbe. Mindenkeppen szeretned megrendelni?(Y/N) ");
            string confirm = Console.ReadLine().ToLower();
            if (confirm == "y")
            {
                List<IMegrendelheto> lista = new List<IMegrendelheto>(bevasarloKosar);
                int meret = bevasarloKosar.Count;
                var valasztott = new bool[meret];
                legjobbMegrendelheto = new bool[meret];
                legmagasabbPrioritas = 0;
                BevasarloKosar.kosarUrites();
                BevasarloKosar.kosarbaTesz(megrendelheto);
                Felhasznalo.FennmaradoOsszegKeret = Felhasznalo.Osszegkeret - (int)megrendelheto.Ar;
                var osszPrioritas = lista.Sum(i => i.Prioritas);

                Backpack(lista, valasztott, 0, 0, 0, osszPrioritas);

                // feltoltjuk ujra az eredmennyel
                for (var i = 0; i < meret; i++)
                {
                    if (legjobbMegrendelheto[i]) { kosarbaTesz(lista[i]); Felhasznalo.FennmaradoOsszegKeret -= (int)lista[i].Ar; }
                }
            }
            else
            {
                Console.WriteLine("Rendben! A terméket nem adtuk hozzá a kosárhoz!");
            }

            Console.WriteLine("A kosaradban így a következő termékek vannak: ");
            BevasarloKosar.rendelesLekerdezes();
        }
    }
}
