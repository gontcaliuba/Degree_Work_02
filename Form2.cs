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
        bool isRecording = false;
        public Form2()
        {
            InitializeComponent();
            ContactList cl = new ContactList();
            cl.extractContacts();
            List<ContactSkype> contacts = cl.getContacts();
            string contactList = null;
            for (int i = 0; i < contacts.Count; i++)
            {
                contactList += contacts[i].getID().ToString() + "   " + contacts[i].getName() + "\n";
            }
            richTextBox1.Text = contactList;

            richTextBox1.KeyDown += Form2_KeyDown;
            richTextBox1.KeyUp += Form2_KeyUp;

            this.KeyDown += Form2_KeyDown;
            this.KeyUp += Form2_KeyUp;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Space) return;
            if (isRecording == true) return;
            Image myimage = new Bitmap("isRecording_02.jpg");
            this.BackgroundImage = myimage;
            isRecording = true;
        }

        void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Space) return;
            Image myimage = new Bitmap("isntRecording_02.jpg");
            this.BackgroundImage = myimage;
            isRecording = false;
        }
    }
}
