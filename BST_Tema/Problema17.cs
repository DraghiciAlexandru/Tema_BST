using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema17
    {
        public Problema17(BST<int> bst, int x)
        {
            Console.WriteLine(postordine(bst.Root).Split(',')[x - 1]);
        }

        public String postordine(TreeNode<int> node)
        {
            if (node == null)
                return "";

            return postordine(node.Left) + postordine(node.Right) + node.Data + ",";
        }

    }
}
