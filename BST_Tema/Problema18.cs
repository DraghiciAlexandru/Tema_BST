using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema18
    {
        public Problema18(Ierarhie<int> ierarhie)
        {
            BST<int> bst = new BST<int>();

            Console.WriteLine(bst.isCorect(ierarhie.Root));
        }

    }
}
