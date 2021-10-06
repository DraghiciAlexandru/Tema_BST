using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema11
    {

        public Problema11(TreeNode<int> node, int x, int y)
        {
            findReplace(node, x, y);
        }

        public void findReplace(TreeNode<int> node, int x, int y)
        {
            if (node == null)
                return;

            if (node.Data == x)
                node.Data = y;

            findReplace(node.Left, x, y);
            findReplace(node.Right, x, y);
        }

    }
}
