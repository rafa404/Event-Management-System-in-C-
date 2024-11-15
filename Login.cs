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
    public partial class Login : Form
    {
        public static int UserID { get; private set; }
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            showpasscheckBox.CheckedChanged += showpasscheckBox_CheckedChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void signuplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void showpasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordtextBox.UseSystemPasswordChar = !showpasscheckBox.Checked;
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

            string name = nametextbox.Text;
            string password = passwordtextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Name and Password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI"))
                {
                    con.Open();

                    // Check admin credentials
                    string adminSql = "SELECT COUNT(*) FROM AdminCredentials WHERE AdminName = @Name AND AdminPassword = @Password";
                    using (SqlCommand adminCmd = new SqlCommand(adminSql, con))
                    {
                        adminCmd.Parameters.AddWithValue("@Name", name);
                        adminCmd.Parameters.AddWithValue("@Password", password);

                        int adminCount = (int)adminCmd.ExecuteScalar();

                        if (adminCount > 0)
                        {
                            Console.WriteLine("Admin credentials matched");
                            AdminActionsForm adminActionsForm = new AdminActionsForm();
                            adminActionsForm.Show();
                            this.Hide();
                            return; // Exit the method since admin login is successful
                        }
                    }



                    // Check organiser credentials
                    string organiserSql = "SELECT COUNT(*) FROM Organiser WHERE Name = @Name AND Password = @Password";
                    using (SqlCommand organiserCmd = new SqlCommand(organiserSql, con))
                    {
                        organiserCmd.Parameters.AddWithValue("@Name", name);
                        organiserCmd.Parameters.AddWithValue("@Password", password);

                        int organiserCount = (int)organiserCmd.ExecuteScalar();

                        if (organiserCount > 0)
                        {

                            Console.WriteLine("Admin credentials matched");
                            Creat_Event creat_Event = new Creat_Event();
                            creat_Event.Show();
                            this.Hide();
                            return; // Exit the method since admin login is successful
                        }
                    }



                    // Check regular user credentials
                    string userSql = "SELECT COUNT(*) FROM Registration WHERE Name = @Name AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(userSql, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            string loggedInUserName = name;
                            MessageBox.Show("Login successful!");
                            Choice_page choicePageForm = new Choice_page();
                            choicePageForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Log the full exception details including the stack trace
                Console.WriteLine(ex.ToString()); // or use a logging framework
            }
        }
    }
}
