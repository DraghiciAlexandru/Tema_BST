using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema22
    {
        private BST<int> bst;

        public Problema22(BST<int> bst)
        {
            this.bst = bst;

            deleteMinimDreapta(bst.Root);

            bst.preorder(bst.Root);
        }

        public void deleteMinimDreapta(TreeNode<int> node)
        {
            int min = bst.minim(node.Right);

            bst.delete(bst.Root, min);
        }
    }
}
