using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema9
    {
        int frunze;

        public Problema9(TreeNode<int> node, int k)
        {
            frunze = 0;

            frunzePeK(node, k);

            Console.WriteLine(frunze);
        }

        public void frunzePeK(TreeNode<int> node, int k, int nivel = 0)
        {
            if (node == null)
                return;

            if (nivel == k)
            {
                if (node.Left == null && node.Right == null)
                    frunze++;
            }

            frunzePeK(node.Left, k, nivel + 1);
            frunzePeK(node.Right, k, nivel + 1);
        }

    }
}
