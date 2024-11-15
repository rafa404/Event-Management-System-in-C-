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
    public partial class Edit_Profile : Form
    {
        public int UserID { get; set; }
        public Edit_Profile()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           

            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";

            gendercomboBox.DataSource = gender;


        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirmpasstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void gendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginpagebutton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void confirmchangebutton_Click(object sender, EventArgs e)
        {
            
            string name = nametextbox.Text;
            string address = adresstextBox.Text;
            string email = emailtextBox.Text;
            string gender = gendercomboBox.SelectedItem?.ToString();
            string dob = dateTimePicker1.Value.ToString();
            string password = passtextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI";

            string sql = "UPDATE Registration SET Name = @Name, Address = @Address, Email = @Email, Gender = @Gender, Birthday = @Birthday, Password = @Password WHERE Email = @Email";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Birthday", dob);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserId", UserID);
                // Open the connection
                con.Open();

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Close the connection
                con.Close();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User information updated successfully!");
                }
                else
                {
                    MessageBox.Show("No records updated. Please check the provided information.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
