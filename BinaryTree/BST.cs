using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BST
    {
        public Node? root;
        public void Insert(int input)
        {
            var newItem = new Node() { Value = input };

            if (root == null) { root = newItem; }
            else
            {
                var prev = root;
                while (true)
                {
                    var temp = prev;
                    if(prev.Value > newItem.Value)
                    {
                        temp = temp.left;
                        if(temp == null) { prev.left = newItem; temp = prev; break; }
                        else { prev = temp; }
                    }
                    else
                    {
                        temp = temp.right;
                        if(temp == null) { prev.right = newItem; break; }
                        else { prev = temp; }
                    }
                }
            }
        }

        public void Delete()
        {

        }
    }
}
