using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Mez lakers = new Mez("Lakers mez", 10000, 10, "L");
            Mez warriors = new Mez("Warriors mez", 15000, 6, "XL");
            FutoCipo nike = new FutoCipo("Nike cipő", 21000, 8, 43);
            FutoCipo adidas = new FutoCipo("Adidas cipő", 18800, 9, 42);
            Ujsagelofizetes blikk = new Ujsagelofizetes("Blikk újság",7800,2,12);
            Ujsagelofizetes forbes = new Ujsagelofizetes("Forbes újság",12000,7,12);
            Masszazs sved = new Masszazs("Sved masszázs",8000,10,30);
            Masszazs thai = new Masszazs("Thai masszázs",5000,5,25);

            //feliratkozás
            lakers.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            warriors.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            nike.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            adidas.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            blikk.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            forbes.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            sved.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            thai.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);

            Felhasznalo felhasznalo = new Felhasznalo();

            Console.WriteLine($"Üdvözöllek a rendelési oldalon {felhasznalo.Nev}!\nA költségvetésed: {felhasznalo.Osszegkeret} Ft.\nA következő termékek közül válogathatsz: ");
            MegrendelhetoTarolo.osszesTermekKiirasa();
            Console.WriteLine("Írd be a megvásárolni kívánt termék nevét: ");
            Boolean loop = true;
            while (loop)
            {
                switch (Console.ReadLine())
                {
                    case "Lakers mez":
                        lakers.kosarba();
                        break;
                    case "Warriors mez":
                        warriors.kosarba();
                        break;
                    case "Nike cipő":
                        nike.kosarba();
                        break;
                    case "Adidas cipő":
                        adidas.kosarba();
                        break;
                    case "Blikk újság":
                        blikk.kosarba();
                        break;
                    case "Forbes újság":
                        forbes.kosarba();
                        break;
                    case "Sved masszázs":
                        sved.kosarba();
                        break;
                    case "Thai masszázs":
                        thai.kosarba();
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
            Console.WriteLine("A kosaradban a következő termékek vannak: ");
            BevasarloKosar.rendelesLekerdezes();
        }
    }
}
