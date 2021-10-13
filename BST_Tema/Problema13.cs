using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema13
    {
        public Problema13(BST<int> bst)
        {
            Console.WriteLine(bst.simetric(bst.Root.Left, bst.Root.Right));
        }
    }
}
