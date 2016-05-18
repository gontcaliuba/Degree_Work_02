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
        public Form3()
        {
            InitializeComponent();
            setData();
            
        }

        public void setData()
        {
            RemindRange remindList = new RemindRange("Reminds.xml");
            dateAndTime.Value = remindList.extractLastDateAndTime();
            RemindMessage.Text = remindList.extractLastMessage();
        }
    }
}
