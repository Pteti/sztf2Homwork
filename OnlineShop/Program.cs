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

            Mez lakers = new Mez("Lakers mez", 10000, "L");
            Mez warriors = new Mez("Warriors mez", 15000, "XL");
            FutoCipo nike = new FutoCipo("Nike cipo", 21000, 43);
            FutoCipo adidas = new FutoCipo("Adidas cipo", 18800, 42);
            Ujsagelofizetes blikk = new Ujsagelofizetes("Blikk újság", 7800, 12);
            Ujsagelofizetes forbes = new Ujsagelofizetes("Forbes újság", 12000, 12);
            Masszazs sved = new Masszazs("Sved masszázs", 8000, 30);
            Masszazs thai = new Masszazs("Thai masszázs", 5000, 25);

            //feliratkozás
            lakers.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            warriors.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            nike.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            adidas.Naplozo = new TermekRendelesNaplozo(BevasarloKosar.Naploz);
            blikk.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            forbes.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            sved.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);
            thai.Naplozo = new SzolgaltatasRendelesNaplozo(BevasarloKosar.Naploz);

            Console.WriteLine("1. Termék keresés.\n2. Termék rendelés.\n3. Alku.");
            Boolean outerLoop = true;
            while (outerLoop)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Add meg a keresett termék nevét: ");
                        string keresett = Console.ReadLine();
                        MegrendelhetoTarolo.fabaKereses(keresett);
                        break;
                    case "2":
                        Boolean loop = true;
                        Felhasznalo.Nev = "Felhasznalo";
                        Console.WriteLine($"Üdvözöllek a rendelési oldalon!\nKérlek add meg az összegkereted: ");
                        int osszegkeret = Convert.ToInt32(Console.ReadLine());
                        Felhasznalo.Osszegkeret = osszegkeret;
                        Felhasznalo.FennmaradoOsszegKeret = osszegkeret;

                        Console.WriteLine($"Üdvözöllek a rendelési oldalon {Felhasznalo.Nev}!\nA költségvetésed: {Felhasznalo.Osszegkeret} Ft.\nA következő termékek közül válogathatsz: ");
                        MegrendelhetoTarolo.osszesTermekKiirasa();
                        while (loop)
                        {
                            Console.WriteLine("Amennyiben kérsz valamit, írd be a nevét. Ha nem kérsz mást nyomj egy entert!");
                            switch (Console.ReadLine())
                            {
                                case "Lakers mez":
                                    Console.Write("Mi a termek prioritasa? ");
                                    int prio = Convert.ToInt32(Console.ReadLine());
                                    lakers.kosarba(prio);
                                    break;
                                case "Warriors mez":
                                    Console.Write("Mi a termek prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    warriors.kosarba(prio);
                                    break;
                                case "Nike cipo":
                                    Console.Write("Mi a termek prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    nike.kosarba(prio);
                                    break;
                                case "Adidas cipo":
                                    Console.Write("Mi a termek prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    adidas.kosarba(prio);
                                    break;
                                case "Blikk újság":
                                    Console.Write("Mi a szolgaltatas prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    blikk.kosarba(prio);
                                    break;
                                case "Forbes újság":
                                    Console.Write("Mi a szolgaltatas prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    forbes.kosarba(prio);
                                    break;
                                case "Sved masszázs":
                                    Console.Write("Mi a szolgaltatas prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    sved.kosarba(prio);
                                    break;
                                case "Thai masszázs":
                                    Console.Write("Mi a szolgaltatas prioritasa? ");
                                    prio = Convert.ToInt32(Console.ReadLine());
                                    thai.kosarba(prio);
                                    break;
                                default:
                                    loop = false;
                                    break;
                            }
                        }
                    break;
                    case "3":
                        lakers.arAlkudozas();
                        break;
                    default:
                        outerLoop = false;
                        break;
                }
                Console.WriteLine("1. Termék keresés.\n2. Termék rendelés.,\n3. Termék árának változtatása.");
            }
            Console.WriteLine("A kosaradban a következő termékek vannak: ");
            BevasarloKosar.rendelesLekerdezes();
            Console.WriteLine("\nA termékeket megrendeltük neked!");
            Console.WriteLine("----Köszönjük a vásárlást!----");
        }
    }
}
