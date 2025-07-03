using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(login_user.Text) || string.IsNullOrEmpty(login_pass.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    cnn.Open();
                    string checkUsername = "SELECT COUNT(*) FROM member WHERE LOWER(Name) = @username AND password = @password";
                    MySqlCommand checkCMD = new MySqlCommand(checkUsername, cnn);

                    checkCMD.Parameters.AddWithValue("@username", login_user.Text.Trim().ToLower());
                    checkCMD.Parameters.AddWithValue("@password", login_pass.Text.Trim());

                    int count = Convert.ToInt32(checkCMD.ExecuteScalar());

                    if (count >= 1)
                    {
                        MessageBox.Show("Login successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainStudent mform = new MainStudent();
                        mform.Show();
                        this.Close();
                    }
                    else
                    {
                        string checkUsername1 = "SELECT COUNT(*) FROM staff WHERE LOWER(FirstName) = @username AND password = @password";
                        MySqlCommand checkCMD1 = new MySqlCommand(checkUsername1, cnn);

                        checkCMD1.Parameters.AddWithValue("@username", login_user.Text.Trim().ToLower());
                        checkCMD1.Parameters.AddWithValue("@password", login_pass.Text.Trim());

                        int countt = Convert.ToInt32(checkCMD1.ExecuteScalar());

                        if (countt >= 1)
                        {
                            MessageBox.Show("Login successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainStaff mform = new MainStaff();
                            mform.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                }
            }
        }

    }
}

