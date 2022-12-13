using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private Item? top;

        public void Push(int input)
        {
            var temp = new Item() { Value = input };
            if (top != null)
            {
                temp.Next = top;
                top = temp;
            }
            else
            {
                top = temp;
            }
        }

        public Item? GetTop() => this.top == null ? new Item() { Value = -0} : this.top;

        public bool isEmpty() => this.top == null ? true : false;

        public void Pop()
        {
            if (top != null) { top = top.Next; }
            else
            {
                Console.WriteLine("Empty!");
            }
        }
    }
}
