using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendlist
{
    public class Friend
    {
        private string name;
        private bool inviteStatus;
        private int priority;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool InviteStatus
        {
            get { return inviteStatus; }
            set { inviteStatus = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public Friend(string name, bool inviteStatus, int priority)
        {
            this.name = name;
            this.inviteStatus = inviteStatus;
            this.priority = priority;
        }
    }
}
