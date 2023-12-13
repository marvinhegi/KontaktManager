using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontaktManager
{
    public partial class Form1 : Form
    {
        ContactList contactList = new ContactList();
        public Form1()
        {
            InitializeComponent();

            dataGridViewKontakte.DataSource = contactList.Contacts;
        }

        private void buttonhinzufugen_Click(object sender, EventArgs e)
        {
            if (textBoxEmail != null && textBoxName != null && textBoxPhone != null)
            {
                string Name = textBoxName.Text;
                string Phone = textBoxPhone.Text;
                string Email = textBoxEmail.Text;
                Contact contact = new Contact(Name,Email, Phone);

                contactList.Contacts.Add(contact);

            }
        }
    }
}
