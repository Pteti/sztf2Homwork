using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    static class MegrendelhetoTarolo
    {
        static BinarySearchTree keresoFa = new BinarySearchTree();
        static Node root = null;

        public static void fabaIllesztes(IMegrendelheto megrendelheto)
        {
            root = keresoFa.beilleszt(root, megrendelheto.Megnevezes);
        }

        public static void fabaKereses(IMegrendelheto megrendelheto)
        {
            Console.WriteLine(keresoFa.Keres(root, megrendelheto.Megnevezes));
        }

        public static void osszesTermekKiirasa()
        {
            keresoFa.mindKiir(root);
        }
    }
}
