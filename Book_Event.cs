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
    public partial class Book_Event : Form
    {
        private const string ConnectionString = "data source=LAPTOP-5VIBFPFB\\SQLEXPRESS; database=Event Management System; integrated security=SSPI";
       
        public Book_Event()
        {
            InitializeComponent();
            LoadEventData();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void LoadEventData()
        {
            string query = "SELECT EventID, EventType, EventName, EventDate, Venue, Address FROM [Event Management System].[dbo].[Events]";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                eventdetailsdataGridView.DataSource = dataTable;
                connection.Close();
            }
        }

        private void eventdetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshgridbutton_Click(object sender, EventArgs e)
        {
            LoadEventData();
        }

        private void bookeventbutton_Click(object sender, EventArgs e)
        {
            if (eventdetailsdataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = eventdetailsdataGridView.SelectedCells[0].RowIndex;
                string eventName = eventdetailsdataGridView.Rows[selectedRowIndex].Cells["EventName"].Value?.ToString();
                object eventDateValue = eventdetailsdataGridView.Rows[selectedRowIndex].Cells["EventDate"].Value;

                if (!string.IsNullOrEmpty(eventName) && eventDateValue != null && DateTime.TryParse(eventDateValue.ToString(), out DateTime eventDate))
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            string query = "INSERT INTO [dbo].[BookedEvents] (BookedEventName, BookedEventDate) " +
                                           "VALUES (@EventName, @EventDate)";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@EventName", eventName);
                                command.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = eventDate;

                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Booking made successfully. It cannot be changed in the future.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Thank_You_Page thankYouPage = new Thank_You_Page();
                                    thankYouPage.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to make booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid event details. Please select a valid event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an event to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void gotologinbutton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void choicepagebutton_Click(object sender, EventArgs e)
        {
            Choice_page choicepage = new Choice_page();
            choicepage.Show();
            this.Hide();
        }
    }
}
