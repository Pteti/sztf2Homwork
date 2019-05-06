using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OnlineShop
{
    class Node
    {
        public IMegrendelheto megrendelheto;
        public Node bal;
        public Node jobb;
    }

    class BinarySearchTree
    {
        public static List<IMegrendelheto> megrendelhetoLista = new List<IMegrendelheto>();

        public Node beilleszt(Node root,IMegrendelheto termek)
        {
            if (root == null)
            {
                root = new Node();
                root.megrendelheto = termek;
            }
            else if (string.Compare(termek.Megnevezes,root.megrendelheto.Megnevezes) == -1)
            {
                root.bal = beilleszt(root.bal, termek);
                megrendelhetoLista.Add(termek);
            }
            else
            {
                root.jobb = beilleszt(root.jobb, termek);
                megrendelhetoLista.Add(termek);
            }

            return root;
        }

        public string Keres(Node root, string termek)
        {
            if (root == null)
            {
                return "Nincs ilyen termek/szolgaltatas";
            }

            if (root.megrendelheto.Megnevezes == termek)
            {
                return "Létezik!";
            }

            Keres(root.bal, termek);
            Keres(root.jobb, termek);

            return "Nincs ilyen termek/szolgaltatas";
        }

        public void mindKiir(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.megrendelheto.Megnevezes + " " + root.megrendelheto.Ar + " Ft");

            mindKiir(root.bal);
            mindKiir(root.jobb);
        }
    }
}