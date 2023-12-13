using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktManager
{
    internal class ContactList
    {
        
        BindingList<Contact> contacts;


        public BindingList<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }

        public void Clear()
        {
          
        }
        

        public ContactList()
        {
            contacts = new BindingList<Contact>();
        }
    }

   
}
