using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendlist.LinkedList
{
    class LinkedList
    {
        int count;
        LinkedListNode head;

        public LinkedList()
        {
            head = null;
        }

        public void AddNodeToFront(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;

            count++;
        }
    }
}
