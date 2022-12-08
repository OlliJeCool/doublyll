using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Item
    {
        public int Value { get; set; }
        public Item? nextItem { get; set; }
    }
}
