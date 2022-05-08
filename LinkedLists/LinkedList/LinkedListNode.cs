using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendlist.LinkedList
{
    class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }
}
