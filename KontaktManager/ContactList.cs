using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktManager
{
    internal class ContactList
    {
        IObservable<Contact> contacts;
        

        public IObservable<Contact> Contacts
        {
            get { return contacts; }
        }

        public void Clear()
        {
          
        }
    }

   
}
