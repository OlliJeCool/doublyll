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

        public void insertBehind(Item? item, int input)
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
            if (item.prev == null || item.next == null)
            {
                this.tail = this.head = null;

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

        public Item? GetItem(int input)
        {
            if (this.head != null)
            {
                var temp = this.head.next;
                while (temp != null)
                {
                    if (temp.value == input) { return temp; }
                    temp = temp.next;
                }
                return null;
            }
            return null;
        }

        public bool Contains(int input) => indexOf(input) >= 0 ? true : false;

        #endregion

        #region Print Methods
        public void Print()
        {
            if(this.head != null)
            {
                var temp = this.head;
                while(temp != null)
                {
                    Console.Write($"{temp.value},");
                    temp = temp.next;
                }
            }
        }

        public void PrintRev()
        {
            if(this.tail!= null)
            {
                var temp = this.tail;
                while(temp != null)
                {
                    Console.Write($"{temp.value}, ");
                    temp = temp.prev;
                }
            }
        }
        #endregion
    }
}
