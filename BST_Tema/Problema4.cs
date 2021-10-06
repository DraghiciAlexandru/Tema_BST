using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema4
    {

        public Problema4(TreeNode<int> node)
        {
            afisarePostVarfuriComplete(node);
        }

        public void afisarePostVarfuriComplete(TreeNode<int> node)
        {
            if (node == null)
                return;

            afisarePostVarfuriComplete(node.Left);
            afisarePostVarfuriComplete(node.Right);

            if (node.Left != null && node.Right != null)
                Console.WriteLine(node.Data);
        }

    }
}
