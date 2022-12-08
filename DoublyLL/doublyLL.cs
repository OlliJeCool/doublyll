using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLL
{
    public class doublyLL
    {
        private Item? head;
        private Item? tail;

        public void ínsertHead(int input)
        {
            var temp = new Item() { value = input };
            if (this.tail == null)
            {
                this.tail = this.head = temp; 
            }
            temp.next = this.head;
            this.head.prev = temp;
            this.head = temp;
        }

        public void insertTail(int input)
        {
            var temp = new Item() { value = input };
            if (this.tail == null)
            {
                this.tail = this.head = temp;
            }
            temp.prev= this.tail;
            this.tail.next = temp;
            this.tail = temp;
        }

        public void insertInf(Item? item, int value)
        {
            var temp = new Item() { value = value };
            temp.next = item.next;
            temp.prev = item;
            item.next = temp;
            temp.next.prev = temp;
        }
    }
}
