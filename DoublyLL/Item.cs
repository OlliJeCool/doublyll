using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLL
{
    public class Item
    {
        public Item? prev { get; set; }
        public int value { get; set; }
        public Item? next { get; set; }

    }
}
