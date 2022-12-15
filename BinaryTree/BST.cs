using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BST
    {
        public Node root;
        public void Insert(int input)
        {
            var newItem = new Node() { Value = input };

            if (root == null) { root = newItem; }
            else
            {
                var prev = root;
                while (true)
                {
                    if (input > prev.Value && prev.right != null) { prev.right = newItem; prev.right = prev; continue; }
                    else if(input > prev.Value && prev.right == null) { prev.right = newItem; break; }
                    if (input < prev.Value) { prev.left = newItem; prev.left = prev; continue; }
                    else if(input < prev.Value) { prev.left = newItem; break; }
                }


                if (input < root.Value) { root.left = newItem; }
            }
        }

        public void Print()
        {

        }
    }
}
