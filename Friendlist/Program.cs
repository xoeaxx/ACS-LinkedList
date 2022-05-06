using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendlist;
using Friendlist.LinkedList;

namespace Friendlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Friend> partyList = CreatePartyList();

            PrintList(partyList);
            PrintLength(partyList);
            PrintAcceptedFriends(partyList);
            PrintDeclinedFriends(partyList);
            FindInviteStatus(partyList);
            RemoveFriend(partyList);

            Console.ReadKey();
        }

        private static void RemoveFriend(List<Friend> partyList)
        {
            Friend removeFriend = new Friend(null, false);
            string name;
            Console.WriteLine("Select who to remove: ");
            name = Console.ReadLine();
            foreach (Friend friend in partyList)
            {
                if (friend.Name == name)
                    removeFriend = friend;
            }
            partyList.Remove(removeFriend);
            PrintList(partyList);
        }

        private static void FindInviteStatus(List<Friend> partyList)
        {
            string name;
            bool status;
            Console.Write("Search for a friends invite status\nEnter friends name: ");
            name = Console.ReadLine();
            status = partyList.Find(x => x.Name == name).InviteStatus;
            if (status)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            ClearConsole();
        }

        private static void PrintDeclinedFriends(List<Friend> partyList)
        {
            Console.WriteLine("Declined friends:\n");
            foreach (Friend friend in partyList)
            {
                if (!friend.InviteStatus)
                    Console.WriteLine(friend.Name);
            }
            ClearConsole();
        }

        private static void PrintAcceptedFriends(List<Friend> partyList)
        {
            Console.WriteLine("Accepted friends:\n");
            foreach (Friend friend in partyList)
            {
                if (friend.InviteStatus)
                    Console.WriteLine(friend.Name);
            }
            ClearConsole();
        }

        private static void PrintLength(List<Friend> partyList)
        {
            Console.WriteLine("Length:\n");
            Console.WriteLine(partyList.Count);
            ClearConsole();
        }

        private static void PrintList(List<Friend> partyList)
        {
            foreach (Friend friend in partyList)
                Console.WriteLine(friend.Name);
            ClearConsole();
        }

        private static List<Friend> CreatePartyList()
        {
            List<Friend> partyList = new List<Friend>();
            string inputName = "";
            do
            {
                Friend friend;
                Console.Write("Enter the friend name: ");
                inputName = Console.ReadLine();
                if (inputName != "xxx")
                {
                    string acceptedInv;
                    Console.Write("Have they accepted?(y/n) ");
                    acceptedInv = Console.ReadLine();
                    if (acceptedInv == "y")
                        friend = new Friend(inputName, true);
                    else
                        friend = new Friend(inputName, false);
                    partyList.Add(friend);
                }
            }
            while (inputName != "xxx");
            ClearConsole();
            return partyList;
        }

        private static void ClearConsole()
        {
            Console.WriteLine("Enter to continue:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
