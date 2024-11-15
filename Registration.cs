using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Management_System
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";

            comboBoxgender.DataSource = gender;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nametextbox
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gender combobox
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //adresstextbox
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //sign in button
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpasstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI";

            string name = NametextBox.Text;
            string dob = dateTimePicker1.Value.ToString();
            string gender = string.Empty;
            gender = comboBoxgender.SelectedItem?.ToString();
            string address = adresstextBox.Text;
            string email = emailtextBox.Text;
            string password = passtextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string sql = "INSERT INTO Registration (Name, Address, Email, Gender, Birthday, Password) VALUES ('"
            + name + "', '"
            + address + "', '"
            + email + "', '"
            + gender + "', '"
            + dob + "', '"
            + password + "')";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                // Open the connection
                con.Open();
                cmd.ExecuteNonQuery();
                // Close the connection
                con.Close();
                MessageBox.Show(" Inserted ");

                Login loginForm = new Login();
                loginForm.Show();
            }

        }
    }
}
