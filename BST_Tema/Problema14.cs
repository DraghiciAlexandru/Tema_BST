using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema14
    {

        public Problema14(BST<int> bst)
        {
            Console.WriteLine(nrPare(bst.Root));
        }

        public int nrPare(TreeNode<int> node)
        {
            if (node == null)
                return 0;

            if (node.Data % 2 == 0)
            {
                return 1 + nrPare(node.Left) + nrPare(node.Right);
            }
            else
            {
                return 0 + nrPare(node.Left) + nrPare(node.Right);
            }
        }

    }
}
