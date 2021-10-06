using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema1
    {
        private BST<int> bst;

        public Problema1()
        {
            bst = new BST<int>();
        }

        public void insert(int nr)
        {
            bst.insert(nr);
        }

        public override string ToString()
        {
            return bst.ToString();
        }
    }
}
