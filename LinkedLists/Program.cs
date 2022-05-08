using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendlist;
using Friendlist.LinkedList;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(new Friend("Liam", true));
            linkedList.AddNodeToFront(new Friend("Callum", false));
            linkedList.AddNodeToFront(new Friend("Mack", true));
            linkedList.AddNodeToFront(new Friend("Jacob", false));
            linkedList.PrintList();
            Console.WriteLine("\n");
            linkedList.RemoveFromFront();
            linkedList.PrintList();

            Console.ReadKey();
        }
    }
}
