using System;

namespace BST_Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>();

            bst.insert(12);
            bst.insert(10);
            bst.insert(18);
            bst.insert(8);
            bst.insert(11);
            bst.insert(15);
            bst.insert(20);
            bst.insert(9);
            bst.insert(16);
            bst.insert(17);

            Prob7Corectare prob7Corectare = new Prob7Corectare(bst);
        }
    }
}
