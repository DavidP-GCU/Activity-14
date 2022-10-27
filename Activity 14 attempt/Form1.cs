using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14_attempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add my Friends event handler
        {
            listBoxFriends.Items.Add(textBoxFriends.Text); //Allows user to enter their friends name into txtbox and then into listbox. 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close GUI
            MessageBox.Show("GoodBye");
            this.Close();
        }

        private void maleRadioBtn_CheckedChanged(object sender, EventArgs e) // Male gender event handler
        {
            if (maleRadioBtn.Checked) //Male Gender btn automatically selected. Greet the proffesor. 
            {
                MessageBox.Show("Hello Proffesor"); // Display message. 
            }
        }

        private void femaleRadioBtn_CheckedChanged(object sender, EventArgs e) // Female gender event handler. 
        {
            //If user select female as gender. 
            if (femaleRadioBtn.Checked)
            {
                MessageBox.Show("Hello ma'am"); //Display message. 
            }
        }

        private void checkbx2_CheckedChanged(object sender, EventArgs e) // 21-40 age range checkbox event handler. 
        {
            // If user selects this specific age group. 
            if (checkbx2.Checked)
            {
                MessageBox.Show("I wish I was 21 again."); //Display Message. 
            }
        }
    }
}
