using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Prob5Corectare
    {
        
        public Prob5Corectare(BST<int> bst)
        {

            Console.WriteLine(bst.minim(bst.Root));
            Console.WriteLine(bst.maxim(bst.Root));

        }

    }
}
