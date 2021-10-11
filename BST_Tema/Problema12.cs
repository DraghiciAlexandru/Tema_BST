using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema12
    {
        public Problema12(BST<int> bst1, BST<int> bst2)
        {
            if (bst1.ToString() == bst2.ToString())
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
