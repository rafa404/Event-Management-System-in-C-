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
    public partial class Creat_Event : Form
    {
        public Creat_Event()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            string[] eventtype = new string[5];
            eventtype[0] = "Concert";
            eventtype[1] = "Seminar";
            eventtype[2] = "Wedding";
            eventtype[3] = "Sporting Event";
            eventtype[4] = "Grand Opening";

            eventtypecomboBox.DataSource = eventtype;
        }

        private void LoadEventData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("data source=LAPTOP-5VIBFPFB\\SQLEXPRESS;" +
                    " database=Event Management System; integrated security=SSPI"))
                {
                    string query = "SELECT EventID, EventType, EventName, EventDate, Venue, Address FROM Events";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearEventFields()
        {
            eventtypecomboBox.SelectedIndex = -1;
            eventnametextbox.Clear();
            eventdateTimePicker.Value = DateTime.Today;
            eventvenuetextBox.Clear();
            adresstextBox.Clear();
        }

        private void eventtypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void eventvenuetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchgridtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backtologinbutton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void deletedatabutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int eventID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["EventID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection("data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI"))
                    {
                        string query = "DELETE FROM Events WHERE EventID = @EventID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EventID", eventID);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadEventData(); // Reload the event data in the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void savedatabutton_Click(object sender, EventArgs e)
        {
            string eventType = eventtypecomboBox.SelectedItem?.ToString();
            string eventName = eventnametextbox.Text.Trim();
            DateTime eventDate = eventdateTimePicker.Value.Date;
            string venue = eventvenuetextBox.Text.Trim();
            string address = adresstextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(eventType) || string.IsNullOrWhiteSpace(eventName) ||
                string.IsNullOrWhiteSpace(venue) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all the event details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI"))
                {
                    string query = "INSERT INTO Events (EventType, EventName, EventDate, Venue, Address) " +
                                   "VALUES (@EventType, @EventName, @EventDate, @Venue, @Address)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventType", eventType);
                        command.Parameters.AddWithValue("@EventName", eventName);
                        command.Parameters.AddWithValue("@EventDate", eventDate);
                        command.Parameters.AddWithValue("@Venue", venue);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearEventFields();
                            LoadEventData(); // Reload the event data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to save event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string connectionString = "data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI";
        private void searchgridbutton_Click(object sender, EventArgs e)
        {

            string searchText = searchgridtextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = $"SELECT * FROM [Event Management System].[dbo].[Events] " +
                               $"WHERE EventType LIKE '%{searchText}%' OR " +
                               $"EventName LIKE '%{searchText}%' OR " +
                               $"Venue LIKE '%{searchText}%' OR " +
                               $"Address LIKE '%{searchText}%'";

                using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void adresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshgridbutton_Click_1(object sender, EventArgs e)
        {
            LoadEventData();
        }
    }
}