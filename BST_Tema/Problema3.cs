using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema3
    {
        int h = 0;

        public Problema3(TreeNode<int> node)
        {
            inaltime(node);

            Console.WriteLine(h);
        }

        public void inaltime(TreeNode<int> node, int nr = 0)
        {
            if (node == null)
                return;

            if (nr > h)
            {
                h = nr;
            }

            inaltime(node.Left, nr + 1);
            inaltime(node.Right, nr + 1);
        }

    }
}
