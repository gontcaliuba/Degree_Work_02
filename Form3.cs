using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DegreeWork_01
{
    public partial class Form3 : Form
    {
        bool isRecording = false;
        public Form3()
        {
            InitializeComponent();
            setData();

            RemindMessage.KeyDown += Form3_KeyDown;
            RemindMessage.KeyUp += Form3_KeyUp;
            
        }

        public void setData()
        {
            RemindRange remindList = new RemindRange("Reminds.xml");
            dateAndTime.Value = remindList.extractLastDateAndTime();
            RemindMessage.Text = remindList.extractLastMessage();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Space) return;
            if (isRecording == true) return;
            Image myimage = new Bitmap("isRecording_03.jpg");
            this.BackgroundImage = myimage;
            isRecording = true;
        }

        void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Space) return;
            Image myimage = new Bitmap("isntRecording_03.jpg");
            this.BackgroundImage = myimage;
            isRecording = false;
        }
    }
}
