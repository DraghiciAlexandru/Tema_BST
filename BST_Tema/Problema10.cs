using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema10
    {
        int exista;

        public Problema10(TreeNode<int> node)
        {
            exista = 0;

            verificareConsecutiv(node);

            Console.WriteLine(exista);
        }

        public void verificareConsecutiv(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left != null)
            {
                if (node.Left.Data == node.Data - 1)
                {
                    exista = 1;
                }
            }

            if (node.Right != null)
            {
                if (node.Right.Data == node.Data + 1)
                {
                    exista = 1;
                }
            }

            verificareConsecutiv(node.Left);
            verificareConsecutiv(node.Right);
        }

    }
}
