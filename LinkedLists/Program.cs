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

            linkedList.AddNodeToFront(new Friend("Liam", true, 1));
            linkedList.AddNodeToFront(new Friend("Callum", false, 4));
            linkedList.AddNodeToFront(new Friend("Mack", true, 2));
            linkedList.AddNodeToFront(new Friend("Jacob", false, 3));

            Console.WriteLine("Print list:");
            linkedList.PrintList();

            Console.WriteLine("\nRemove one + print list:");
            linkedList.RemoveFromFront();
            linkedList.PrintList();

            Console.WriteLine("\nAdded Jacob back.");
            linkedList.AddNodeToFront(new Friend("Jacob", false, 3));

            Console.WriteLine("\nPrint accepted:");
            linkedList.PrintInvAccepted();

            Console.WriteLine("\nPrint declined:");
            linkedList.PrintInvDeclined();

            Console.WriteLine("\nFind invite status (Callum):");
            linkedList.FindInvStatus("Callum");

            Console.WriteLine("\nPrint length:");
            linkedList.PrintLength();

            Console.WriteLine("\nRemove specified (Callum):");
            linkedList.Remove("Callum");
            linkedList.PrintList();

            Console.WriteLine("\nIn order of priority:");
            linkedList.Sort();
            linkedList.PrintList();

            Console.ReadKey();
        }
    }
}
