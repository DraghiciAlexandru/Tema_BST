using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema8
    {
        int isPlin = 1;

        public Problema8(TreeNode<double> node)
        {
            plin(node);

            Console.WriteLine(isPlin);
        }

        public void plin(TreeNode<double> node)
        {
            if (node != null)
            {
                if ((node.Left != null && node.Right == null) || (node.Left == null && node.Right != null))
                    isPlin = 0;
                else
                {
                    plin(node.Left);
                    plin(node.Right);
                }
            }
        }

    }
}
