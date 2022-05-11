﻿using System;
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

        public void Sort()
        {
            for (int i = 0; i < count; i++)
            {                
                LinkedListNode runner = head;
                LinkedListNode node = null;
                while (runner != null)
                {
                    if (head.next.data.Priority > head.data.Priority)
                    {
                        LinkedListNode temp = head;
                        head = head.next;
                        head.next = head;
                    }
                    runner = runner.next;

                }
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

        public void PrintLength()
        {
            Console.WriteLine(count);
        }

        public void RemoveFromFront()
        {
            LinkedListNode tempNode = null;
            tempNode = head.next;
            head = tempNode;
        }

        public void Remove(string name) // this works but i dont understand why
        {
            LinkedListNode previous = null;
            for(var node = head; node != null; node = node.next)
            {
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
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data.Name);
                runner = runner.next;
            }
        }

    }
}
