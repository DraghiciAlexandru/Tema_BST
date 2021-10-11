using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema21
    {
        public BST<int> bst;

        public Problema21(BST<int> bst)
        {
            this.bst = bst;

            inserareDubluFrunza(bst.Root);

            bst.preorder(bst.Root);
        }

        public void inserareDubluFrunza(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null)
            {
                if (bst.find(bst.Root, node.Data * 2) == null) 
                    bst.insert(node.Data * 2);
                return;
            }

            inserareDubluFrunza(node.Left);
            inserareDubluFrunza(node.Right);
        }

    }
}
