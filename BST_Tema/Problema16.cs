using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema16
    {
        public BST<int> bst;

        public Problema16(BST<int> bst)
        {
            this.bst = bst;

            afisareAlternativa(bst.Root);
        }

        public void afisareAlternativa(TreeNode<int> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Data + " ");

            if (bst.nivel(bst.Root, node.Data) % 2 == 0)
                afisareAlternativa(node.Left);
            else
                afisareAlternativa(node.Right);
        }

    }
}
