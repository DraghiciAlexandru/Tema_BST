using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Tema
{
    class Problema7
    {
        public TreeNode<int> root;

        public Problema7(TreeNode<int> node)
        {
            root = node;

            deleteFrunze(node);

            Console.WriteLine(afisare());
        }

        public void deleteFrunze(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left != null)
            {
                if (node.Left.Left == null && node.Left.Right == null)
                    node.Left = null;
                else
                {
                    deleteFrunze(node.Left);
                    deleteFrunze(node.Right);
                }
            }

            if (node.Right != null)
            {
                if (node.Right.Left == null && node.Right.Left == null)
                    node.Right = null;
                else
                {
                    deleteFrunze(node.Left);
                    deleteFrunze(node.Right);
                }
            }
        }

        public string afisare()
        {
            String text = "";

            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();

            if (root != null)
                queue.Enqueue(root);

            while (queue.Count > 0)
            {
                if (queue.Peek().Left != null)
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                text += queue.Dequeue().Data.ToString() + ";";
            }

            return text;
        }
    }
}
