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
            count = 0;
        }

        public void AddNodeToFront(Friend data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data.Name);
                runner = runner.next;
            }
        }

        public void FindInvStatus(string name)
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                if(runner.data.Name == name)
                {
                    Console.WriteLine(runner.data.InviteStatus);
                    return;
                }
                    runner = runner.next;
            }
        }
        
        public void PrintInvAccepted()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                if (runner.data.InviteStatus)
                {
                    Console.WriteLine(runner.data.Name);
                }
                    runner = runner.next;
            }
        }
        
        public void PrintInvDeclined()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                if (!runner.data.InviteStatus)
                {
                    Console.WriteLine(runner.data.Name);
                }
                    runner = runner.next;
            }
        }

        public void RemoveFromFront()
        {
            LinkedListNode tempNode = null;
            tempNode = head.next;
            head = tempNode;
        }

    }
}
