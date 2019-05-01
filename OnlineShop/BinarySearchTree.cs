using System;
using System.Diagnostics;

namespace OnlineShop
{
    class Node
    {
        public string termekNev;
        public Node bal;
        public Node jobb;
    }

    class BinarySearchTree
    { 
        public Node beilleszt(Node root,string nev)
        {
            if (root == null)
            {
                root = new Node();
                root.termekNev = nev;
            }
            else if (string.Compare(nev,root.termekNev) == -1)
            {
                root.bal = beilleszt(root.bal, nev);
            }
            else
            {
                root.jobb = beilleszt(root.jobb, nev);
            }

            return root;
        }

        public string Keres(Node root,string nev)
        {
            if (root == null)
            {
                return "Nincs ilyen termek/szolgaltatas";
            }

            if (root.termekNev == nev)
            {
                return "Létezik!";
            }

            Keres(root.bal, nev);
            Keres(root.jobb, nev);

            return "Nincs ilyen termek/szolgaltatas";
        }

        public void mindKiir(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.termekNev);

            mindKiir(root.bal);
            mindKiir(root.jobb);
        }
    }
}