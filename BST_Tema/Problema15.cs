using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema15
    {
        public Problema15(BST<int> bst)
        {
            afisareStanga(bst.Root);
        }

        public void afisareStanga(TreeNode<int> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Data + " ");

            afisareStanga(node.Left);
        }

    }
}
