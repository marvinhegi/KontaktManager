using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public ContactList()
        {
            contacts = new BindingList<Contact>();
        }


        public void Clear()
        {
            Contacts.Clear();
        }

        public void ExportCsv(ContactList contactList)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Kontakte exportieren";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                string path = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        // Write the header row
                        sw.WriteLine("Name;Email;Phone");

                        // Write each contact to the file
                        foreach (Contact contact in contactList.Contacts)
                        {
                            sw.WriteLine($"{contact.Name};{contact.Email};{contact.Phone}");
                        }

                        MessageBox.Show("Export erfolgreich abgeschlossen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Export: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void ImportCsv(ContactList contactList)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Kontakte importieren";
            openFileDialog.DefaultExt = "csv";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                contactList.Clear();
                string path = openFileDialog.FileName;

                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        // Übergehe die Header-Zeile
                        sr.ReadLine();

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] values = line.Split(';');

                            if (values.Length == 3)
                            {
                                // Erstelle einen neuen Kontakt und füge ihn zur Liste hinzu
                                Contact contact = new Contact();
                                contact.Name = values[0];
                                contact.Email = values[1];
                                contact.Phone = values[2];

                                Contacts.Add(contact);
                            }
                            else
                            {
                                // Fehlerhafte Zeile in der CSV-Datei
                                MessageBox.Show($"Fehler beim Lesen der Zeile: {line}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        MessageBox.Show("Import erfolgreich abgeschlossen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Import: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }


}



