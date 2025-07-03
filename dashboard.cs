using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    public partial class dashboard : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;
        public dashboard()
        {
            InitializeComponent();
            cnn = new MySqlConnection(connectionString);
            displaycount();
        }

        public void displaycount()
        {

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    // SQL query to count rows
                    string query = "SELECT COUNT(*) FROM book WHERE Status = 'available'";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        // Execute the query and get the count
                        int availableBooksCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Update the label with the count
                        availablebooks.Text = $"{availableBooksCount}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    // SQL query to count rows
                    string query = "SELECT COUNT(*) FROM book WHERE Status = 'borrowed'";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        // Execute the query and get the count
                        int availableBooksCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Update the label with the count
                        issuedbooks.Text = $"{availableBooksCount}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    // SQL query to count rows
                    string query = "SELECT COUNT(*) FROM book WHERE Status = 'requested'";

                    using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                    {
                        // Execute the query and get the count
                        int availableBooksCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Update the label with the count
                        requestedbooks.Text = $"{availableBooksCount}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
