using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LibraryMS
{
    public partial class RequestBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;
        string status = "requested";
        public RequestBooks()
        {
            InitializeComponent();

            displayBooks();
            cnn = new MySqlConnection(connectionString);
        }

        private void returnBooks1_Load(object sender, EventArgs e)
        {

        }

        public void displayBooks()
        {
            availablebooks dab = new availablebooks();
            List<availablebooks> listData = dab.availableBooksData();

            dataGridView1.DataSource = listData;
        }

        private void requestBooks_requestBtn_Click(object sender, EventArgs e)
        {
            if (requestBooks_title.Text == ""
               || requestBooks_author.Text == ""
               || requestBooks_genre.Text == ""
               || requestBooks_ISBN.Text == ""
                )
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cnn.State != ConnectionState.Open)
                {
                    try
                    {
                        cnn.Open();
                        string insertData = "INSERT INTO book " +
                            "(Title, Author, Genre, ISBN, Status) " +
                            "VALUES (@Title, @Author, @Genre, @ISBN, @Status)";
                        MySqlCommand cmd = new MySqlCommand(insertData, cnn);

                        int isbn = int.Parse(requestBooks_ISBN.Text.Trim());
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@Title", requestBooks_title.Text.Trim());
                        cmd.Parameters.AddWithValue("@Author", requestBooks_author.Text.Trim());
                        cmd.Parameters.AddWithValue("@Genre", requestBooks_genre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", status);
                   

                        // Execute the second query
                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                displayBooks();

                                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error connecting to database:" + ex);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            requestBooks_title.Text = "";
            requestBooks_author.Text = "";
            requestBooks_genre.Text = "";
            requestBooks_ISBN.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
