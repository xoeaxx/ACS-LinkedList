using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendlist.LinkedList
{
    class LinkedListNode
    {
        public Friend data;
        public LinkedListNode next;

        public LinkedListNode(Friend data)
        {
            this.data = data;
            next = null;
        }
    }
}
