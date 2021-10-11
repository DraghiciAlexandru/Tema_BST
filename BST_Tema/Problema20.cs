using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema20
    {
        public Problema20(BST<int> bst)
        {
            int[] vector = new int[100];
            int n = 0;

            inorder(bst.Root, vector, n);

            for (int i = 0; i < vector.Length; i++) 
            {
                Console.WriteLine(vector[i]);
            }
        }

        public void inorder(TreeNode<int> node, int[] vector, int n)
        {
            if (node == null)
                return;

            inorder(node.Left, vector, n);
            vector[n] = node.Data;
            n = n + 1;
            inorder(node.Right, vector, n + 1);
        }
    }
}
