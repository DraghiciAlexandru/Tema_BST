using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Prob6Corectare
    {
        public BST<double> bst;
        public double suma;

        public Prob6Corectare(BST<double> bst, int k)
        {
            this.bst = bst;
            suma = 0;

            sumaNivelK(bst.Root, k);

            Console.WriteLine(suma);
        }

        public void sumaNivelK(TreeNode<double> node, int k)
        {
            if (node == null)
                return;

            if (bst.nivel(bst.Root, node.Data) == k)
                suma += node.Data;

            sumaNivelK(node.Left, k);
            sumaNivelK(node.Right, k);
        }

    }
}
