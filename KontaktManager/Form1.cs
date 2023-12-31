﻿using System;
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
            if (textBoxEmail.Text != "" && textBoxName.Text != "" && textBoxPhone.Text != "")
            {
                

                Contact contact = new Contact();
                contact.Name = textBoxName.Text;
                contact.Email = textBoxEmail.Text;
                contact.Phone = textBoxPhone.Text;
                
                contactList.Contacts.Add(contact);

                textBoxName.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
            else
            {
                MessageBox.Show("Fülle alle felder aus");
            }
        }

        private void buttonListeLoschen_Click(object sender, EventArgs e)
        {
            contactList.Clear();
        }

        private void buttonExportcsv_Click(object sender, EventArgs e)
        {
            try
            {

                contactList.ExportCsv(contactList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonImportcsv_Click(object sender, EventArgs e)
        {
            try
            {
                contactList.ImportCsv(contactList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
