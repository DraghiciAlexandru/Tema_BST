using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Prob2Corectare
    {
        public Prob2Corectare(BST<int> bst)
        {
            bst.inorderPar(bst.Root);
        }
    }
}
