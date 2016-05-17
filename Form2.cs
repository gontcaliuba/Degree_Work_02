using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DegreeWork_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ContactList cl = new ContactList();
            cl.extractContacts();
            List<ContactSkype> contacts = cl.getContacts();
            for (int i = 0; i < contacts.Count; i++)
            {
                ContactsTable.Rows.Add();
                ContactsTable.Rows[i].Cells[0].Value = contacts[i].getID();
                ContactsTable.Rows[i].Cells[1].Value = contacts[i].getName();
            }
        }
    }
}
