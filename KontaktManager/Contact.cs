using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktManager
{
    public class Contact
    {
        string name;
        string email;
        string phone;

        public string Name
        {
            get { return name; }
        }

        public string Email
        {
            get { return email; }
        }

        public string Phone
        {
            get { return phone; }
        }

        public Contact(string Nameinput, string Emailinput, string Phoneinput)
        {
            name = Nameinput;
            email = Emailinput;
            phone = Phoneinput;
        }

    }
}
