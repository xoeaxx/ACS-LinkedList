using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendlist.LinkedList;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(1);
            linkedList.AddNodeToFront(2);
            linkedList.AddNodeToFront(4);
            linkedList.AddNodeToFront(6);
            linkedList.AddNodeToFront(8);
            linkedList.AddNodeToFront(9);
            linkedList.AddNodeToFront(5);
            linkedList.PrintList();

            Console.ReadKey();
        }
    }
}
