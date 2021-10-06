using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema5
    {
        int minim = int.MaxValue, maxim = int.MinValue;

        public Problema5(TreeNode<int> node)
        {
            MinMax(node);
        }

        public void MinMax(TreeNode<int> node)
        {
            TreeNode<int> root = node;

            while (root.Left != null)
                root = root.Left;

            minim = root.Data;

            root = node;

            while (root.Right != null) 
                root = root.Right;

            maxim = root.Data;

            Console.WriteLine(minim);
            Console.WriteLine(maxim);

        }

    }
}
