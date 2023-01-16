using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLL
{
    public class doublyLL
    {
        #region Fields
        private Item? head;
        private Item? tail;

        #endregion

        #region Insert Methods
        public void insertHead(int input)
        {
            var temp = new Item() { value = input };
            if (this.tail == null)
            {
                this.head = this.tail = temp;
            }
            else
            {
                temp.next = this.head;
                this.head.prev = temp;
                this.head = temp;
            }

        }

        public void insertTail(int input)
        {
            var temp = new Item() { value = input };
            if (this.tail == null)
            {
                this.tail = this.head = temp;
            }
            else
            {
                temp.prev = this.tail;
                this.tail.next = temp;
                this.tail = temp;
            }

        }

        public void insertInf(Item item, int input)
        {
            var temp = new Item() { value = input };
            if (item.prev == null)
            {
                temp.next = item;
                item.prev = temp;
                this.head = temp;
            }
            else
            {
                temp.next = item;
                item.prev.next = temp;
                temp.prev = item.prev;
                item.prev = temp;

 
            }
        }

        public void insertBehind(Item item, int input)
        {
            var temp = new Item() { value = input };
            if (item.next == null)
            {
                temp.prev = item;
                item.next = temp;
                this.tail = temp;
            }
            else
            {
                item.next.prev = temp;
                temp.next = item.next;
                temp.prev = item;
                item.next = temp;
            }
        }

        #endregion

        #region Delete Methods
        public void DeleteHead()
        {
            if (this.tail.prev == null)
            {
                this.head = this.tail = null;
            }
            else
            {
                this.head = this.head.next;
                this.head.prev = null;
            }
        }

        public void DeleteTail()
        {
            this.tail = this.tail.prev;
            this.tail.next = null;
        }

        public void Delete(Item? item)
        {

            if(item.prev == null)
            {
                this.head = item.next;
                this.head.prev = null;
            }
            else if(item.next == null)
            {
                this.tail = item.prev;
                this.tail.next = null;
            }
            else
            {
                item.prev.next = item.next;
                item.next.prev = item.prev;
            }
        }
        #endregion

        #region Index and Contains Methods
        public int indexOf(int input)
        {
            if (this.head != null)
            {
                var temp = this.head;
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

        public Item? GetItem(int input)
        {
            Item temp = this.head;
            int index = indexOf(input);
            if (index == -1)
            {
                Console.WriteLine("Item not in list.");
                return null;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.next;
                }
                return temp;
            }
        }

        public bool Contains(int input) => indexOf(input) >= 0 ? true : false;

        #endregion

        #region Print Methods
        public void Print()
        {
            if (this.head != null)
            {
                var temp = this.head;
                while (temp != null)
                {
                    Console.Write($"{temp.value} ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }

        public void PrintRev()
        {
            if (this.tail != null)
            {
                var temp = this.tail;
                while (temp != null)
                {
                    Console.Write($"{temp.value} ");
                    temp = temp.prev;
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
