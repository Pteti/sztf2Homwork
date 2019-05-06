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

        public static void prioritasRendezes(IMegrendelheto megrendelheto)
        {
            Console.WriteLine("Ez a termek nem fer bele a keretedbe. Mindenkeppen szeretned megrendelni?(Y/N) ");
            string confirm = Console.ReadLine().ToLower();
            if (confirm == "y")
            {
                List<IMegrendelheto> lista = new List<IMegrendelheto>(bevasarloKosar);
                BevasarloKosar.kosarUrites();
                BevasarloKosar.kosarbaTesz(megrendelheto);
                Felhasznalo.FennmaradoOsszegKeret = Felhasznalo.Osszegkeret - (int)megrendelheto.Ar;
                lista = prioRendezes(lista);
                int i = 0;
                while (Felhasznalo.FennmaradoOsszegKeret > 0 && i < lista.Count())
                {
                    if (lista[i].Ar < Felhasznalo.FennmaradoOsszegKeret)
                    {
                        BevasarloKosar.kosarbaTesz(lista[i]);
                        Felhasznalo.FennmaradoOsszegKeret -= (int)lista[i].Ar;
                    }
                    i++;
                }

            }
            else
            {
                Console.WriteLine("Rendben! A terméket nem adtuk hozzá a kosárhoz!");
            }

            Console.WriteLine("A kosaradban így a következő termékek vannak: ");
            BevasarloKosar.rendelesLekerdezes();
        }

        public static List<IMegrendelheto> prioRendezes(List<IMegrendelheto> lista)
        {
            List<IMegrendelheto> rendezettLista = lista;
            for (int i = 0; i < rendezettLista.Count; i++)
            {
                for (int j = 0; j < rendezettLista.Count; j++)
                {
                    if (rendezettLista[j].Prioritas < rendezettLista[i].Prioritas)
                    {
                        IMegrendelheto temp = rendezettLista[i];
                        rendezettLista[i] = rendezettLista[j];
                        rendezettLista[j] = temp;
                    }
                }
            }
            return rendezettLista;
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
    }
}
