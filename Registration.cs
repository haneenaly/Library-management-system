using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
            MySqlConnection cnn = new MySqlConnection(connectionString);

            if (string.IsNullOrEmpty(register_name.Text) || string.IsNullOrEmpty(register_ID.Text) || string.IsNullOrEmpty(register_password.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cnn.Open();

                // Check if the username already exists
                string checkUsernameQuery = "SELECT COUNT(*) FROM member WHERE Name = @username";
                MySqlCommand checkCMD = new MySqlCommand(checkUsernameQuery, cnn);
                checkCMD.Parameters.AddWithValue("@username", register_name.Text.Trim());

                int count = Convert.ToInt32(checkCMD.ExecuteScalar());

                if (count >= 1)
                {
                    MessageBox.Show(register_name.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Prepare the INSERT statement
                    string query = "INSERT INTO member (MemberID, Name, password, RegistrationDate) VALUES (@memberID, @username, @password, @date)";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@memberID", register_ID.Text);
                    cmd.Parameters.AddWithValue("@username", register_name.Text);
                    cmd.Parameters.AddWithValue("@password", register_password.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login lform = new Login();
                        lform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = checkBox1.Checked ? '\0' : '*'; // Toggle password visibility
        }
    }
}
