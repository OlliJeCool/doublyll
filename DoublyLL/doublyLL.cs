using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public void insertInf(Item? item, int input)
        {
            var temp = new Item() { value = input };
            if (item.prev == null)
            {
                temp.next = item;
                item.prev = temp;
            }
            else
            {
                temp.next = item.next;
                temp.prev = item;
                item.next = temp;
                temp.next.prev = temp;
            }
        }

        public void insertBehin(Item? item, int input)
        {
            var temp = new Item() { value = input };
            if(item.next == null)
            {
                temp.prev = item;
                item.next = temp;
            }
            else
            {
                item.next.prev = temp;
                temp.next= item.next;
                temp.prev = item;
                item.next = temp;
            }
        }

        public int indexOf(int input)
        {
            if (this.head != null)
            {
                var temp = this.head.next;
                int count = 0;
                while (temp != null)
                {
                    if (temp.value == input) { return count; }
                    temp = temp.next;
                    count++;
                }
                return -1;
            }
            return -1;
        }

        public bool Contains(int input) => indexOf(input) >= 0 ? true : false;
    }
}
