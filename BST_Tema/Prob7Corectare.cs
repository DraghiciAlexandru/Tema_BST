using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Prob7Corectare
    {
        public BST<int> bst;

        public Prob7Corectare(BST<int> bst)
        {
            this.bst = bst;

            deleteFrunze(bst.Root);

            bst.preorder(bst.Root);
        }

        public void deleteFrunze(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null)
                bst.delete(bst.Root, node.Data);

            deleteFrunze(node.Left);
            deleteFrunze(node.Right);

        }

    }
}
