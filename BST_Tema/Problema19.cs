using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema19
    {
        Random random;

        public Problema19(int n)
        {
            random = new Random();

            Console.WriteLine(generareCub(n).ToString());
        }

        public BST<int> generareCub(int n)
        {
            BST<int> bst = new BST<int>();

            for (int i = 0; i < n; i++)
            {
                bst.insert((int)Math.Pow(random.Next(1, 1000), 3));
            }

            return bst;
        }

    }
}
