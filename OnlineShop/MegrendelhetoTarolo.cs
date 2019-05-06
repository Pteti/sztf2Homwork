using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public static class MegrendelhetoTarolo
    {
        static BinarySearchTree keresoFa = new BinarySearchTree();
        static Node root = null;

        public static void fabaIllesztes(IMegrendelheto megrendelheto)
        {
            root = keresoFa.beilleszt(root, megrendelheto);
        }

        public static void fabaKereses(string megrendelheto)
        {
            Console.WriteLine(keresoFa.Keres(root, megrendelheto));
        }

        public static void osszesTermekKiirasa()
        {
            keresoFa.mindKiir(root);
        }
    }
}
