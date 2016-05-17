using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;

namespace DegreeWork_01
{
    public class ContactList
    {
        List<ContactSkype> contactList = new List<ContactSkype>();
        Skype skype = new Skype();

        public void extractContacts()
        {
            foreach (User User in skype.Friends)
            {
                if (User.BuddyStatus == SKYPE4COMLib.TBuddyStatus.budFriend)
                {
                    contactList.Add(new ContactSkype(contactList.Count, User.Handle));
                }
            }
        }
        public List<ContactSkype> getContacts()
        {
            return contactList;
        }
    }
}
