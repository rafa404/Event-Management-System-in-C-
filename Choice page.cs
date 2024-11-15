using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class Choice_page : Form
    {
        public Choice_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Choice_page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookeventbutton_Click(object sender, EventArgs e)
        {
            Book_Event bookinForm = new Book_Event();
            bookinForm.Show();
            this.Hide();
        }

        private void volunteerbutton_Click(object sender, EventArgs e)
        {

        }

        private void editprofilebutton_Click(object sender, EventArgs e)
        {
            Edit_Profile editProfileForm = new Edit_Profile();
            editProfileForm.Show();
            this.Hide();
        }

        private void closeprogrambutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
