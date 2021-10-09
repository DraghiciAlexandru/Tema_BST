using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Prob3Corectare
    {

        public Prob3Corectare(TreeNode<double> node)
        {
            Console.WriteLine(inaltimea(node));
        }

        public int inaltimea(TreeNode<double> node)
        {
            if (node == null)
                return -1;

            return 1 + Math.Max(inaltimea(node.Left), inaltimea(node.Right));
        }

    }
}
