using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema21
    {
        public BST<int> bst;

        public Problema21(BST<int> bst)
        {
            this.bst = bst;

            inserareDubluFrunza(frunze(bst.Root));

            bst.preorder(bst.Root);
        }

        public List<TreeNode<int>> frunze(TreeNode<int> node)
        {
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            List<TreeNode<int>> list = new List<TreeNode<int>>();

            if (node != null)
                queue.Enqueue(node);

            while(queue.Count>0)
            {
                if(queue.Peek().Left!=null)
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                if (queue.Peek().Left == null && queue.Peek().Right == null)
                    list.Add(queue.Peek());

                queue.Dequeue();
            }

            return list;
        }

        public void inserareDubluFrunza(List<TreeNode<int>> frunze)
        {
            foreach (TreeNode<int> x in frunze) 
            {
                bst.insert(x.Data * 2);
            }
        }

    }
}
