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
        LinkedListNode first;

        public LinkedList()
        {
            first = null;
            count = 0;
        }

        public void AddNodeToFront(Friend data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = first;
            first = node;
            count++;
        }

        public void Sort()
        {
            for (int i = 0; i < count; i++)
            {                
                LinkedListNode runner = first;
                LinkedListNode node = null;
                while (runner != null)
                {
                    if (first.next.data.Priority > first.data.Priority)
                    {
                        LinkedListNode temp = first;
                        first = first.next;
                        first.next = first;
                    }
                    runner = runner.next;

                }
            }
        }


        public void FindInvStatus(string name)
        {
            LinkedListNode runner = first;
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
            LinkedListNode runner = first;
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
            LinkedListNode runner = first;
            while (runner != null)
            {
                if (!runner.data.InviteStatus)
                {
                    Console.WriteLine(runner.data.Name);
                }
                    runner = runner.next;
            }
        }

        public void PrintLength()
        {
            Console.WriteLine(count);
        }

        public void RemoveFromFront()
        {
            LinkedListNode tempNode = null;
            tempNode = first.next;
            first = tempNode;
        }

        public void Remove(string name) // this works but i dont understand why
        {
            LinkedListNode previous = null;
            for(var node = first; node != null; node = node.next)
            {
                if(node.data.Name == first.data.Name)
                {
                    RemoveFromFront();
                    return;
                }

                if (node.data.Name == name)
                {
                    previous.next = node.next;
                    return;
                }
                previous = node;
            }

        }
        public void PrintList()
        {
            LinkedListNode runner = first;
            while (runner != null)
            {
                Console.WriteLine(runner.data.Name);
                runner = runner.next;
            }
        }

    }
}
