using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class AdminActionsForm : Form
    {
        private const string ConnectionString = "data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI";

        public AdminActionsForm()
        {
            InitializeComponent();
            LoadUserData();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AdminActionsForm_Load(object sender, EventArgs e)
        {
            // Call the method to load data into the DataGridView when the form loads
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT TOP 1000 [UserID], [Name], [Address], [Email], [Gender], [Birthday], [Password] FROM [Event Management System].[dbo].[Registration]";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchTerm = datasearchtextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string query = $"SELECT * FROM [Event Management System].[dbo].[Registration] WHERE [Name] LIKE '%{searchTerm}%'";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateinfobutton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            // Get the UserID of the selected user
            string userId = dataGridView1.Rows[rowIndex].Cells["UserID"].Value.ToString();

            string newName = dataGridView1.Rows[rowIndex].Cells["Name"].Value?.ToString();
            string newAddress = dataGridView1.Rows[rowIndex].Cells["Address"].Value?.ToString();
            string newEmail = dataGridView1.Rows[rowIndex].Cells["Email"].Value?.ToString();
            string newGender = dataGridView1.Rows[rowIndex].Cells["Gender"].Value?.ToString();
            string newPassword = dataGridView1.Rows[rowIndex].Cells["Password"].Value?.ToString();


            if (!string.IsNullOrEmpty(newName))
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = $"UPDATE [Event Management System].[dbo].[Registration] " +
                                   $"SET [Name] = @NewName " +
                                   $"WHERE [UserID] = @UserId";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@NewName", newName);
                    command.Parameters.AddWithValue("@NewAddress", newAddress);
                    command.Parameters.AddWithValue("@NewEmail", newEmail);
                    command.Parameters.AddWithValue("@NewGender", newGender);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@UserId", userId);
                    
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reload the user data after updating
                    LoadUserData();
                }
            }
            else
            {
                MessageBox.Show("Please enter a new name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
           
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

           
            string userId = dataGridView1.Rows[rowIndex].Cells["UserID"].Value.ToString();

           
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                DeleteUser(userId);

                
                LoadUserData();
            }
        }

        private void DeleteUser(string userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = $"DELETE FROM [Event Management System].[dbo].[Registration] WHERE [UserID] = '{userId}'";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record found with the provided UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            private void datasearchtextBox_TextChanged(object sender, EventArgs e)
            {

            }

        private void loginpagebackbutton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Login form
            Login loginForm = new Login();

            // Show the Login form
            loginForm.Show();

            // Close or hide the current form if needed
            this.Hide();
        }
    }
    }

