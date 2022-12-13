using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private Item? head;
        private Item? tail;


        public void Insert(int value)
        {
            var temp = new Item() { Value = value };
            if(this.tail == null)
            {
                this.tail = this.head = temp;
            }
            else
            {
                this.tail.nextItem = temp;
                this.tail = temp; 
            }
        }

        public void Remove()
        {
            if(this.tail!= null)
            {
                this.head = this.head.nextItem;
                if(this.head == null) { this.tail= null; }
            }
        }

        public bool isEmpty() => this.tail == null ? true : false;

        public Item? getFirst() => this.head == null ? null : this.head;
    }
}
