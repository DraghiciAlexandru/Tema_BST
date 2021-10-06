using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema6
    {
        public double s = 0;
        public Problema6(TreeNode<double> node, int k)
        {
            sumaNivelK(node, k);

            Console.WriteLine(s);
        }

        public void sumaNivelK(TreeNode<double> node, int k, int nivel = 0)
        {
            if (node == null)
                return;

            if (nivel == k)
                s += node.Data;

            sumaNivelK(node.Left, k, nivel + 1);
            sumaNivelK(node.Right, k, nivel + 1);
        }

    }
}
