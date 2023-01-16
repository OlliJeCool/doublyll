using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class App
    {
        public void Run()
        {
            var tree = new BST();
            tree.Insert(8);
            tree.Insert(7);
            tree.Insert(9);
            tree.Insert(10);
        }
    }
}
