using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema2
    {
        public Problema2()
        {

        }

        public void inorderLiniiPare(TreeNode<int> node, int nivel = 0)
        {
            if (node == null)
                return;

            inorderLiniiPare(node.Left, nivel + 1);

            if (nivel % 2 == 0)
                Console.WriteLine(node.Data);

            inorderLiniiPare(node.Right, nivel + 1);
        }
    }
}
