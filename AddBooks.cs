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
using System.IO;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;

namespace LibraryMS
{
    public partial class AddBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;
        public AddBooks()
        {
            InitializeComponent();

            displayBooks();
            cnn = new MySqlConnection(connectionString);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (addbook_title.Text == ""
               || addbook_author.Text == ""
               || addbook_genre.Text == ""
               || addbook_ISBN.Text == ""
               || addbook_status.Text == ""
               || addbook_branch.Text == ""
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

                        // First query: Retrieve the BranchID
                        string branch = "SELECT BranchID FROM branches WHERE Location = @Branch";
                        MySqlCommand branchcmd = new MySqlCommand(branch, cnn);
                        branchcmd.Parameters.AddWithValue("@Branch", addbook_branch.Text.Trim());

                        int branchId; // To store the BranchID
                        using (MySqlDataReader reader = branchcmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                branchId = reader.GetInt32("BranchID"); // Assuming BranchID is an int
                            }
                            else
                            {
                                // Handle the case where the branch is not found
                                MessageBox.Show("Branch not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }




                        // Second query: Insert data into the book table using the retrieved BranchID
                        string insertData = "INSERT INTO book " +
                            "(Title, Author, Genre, ISBN, Status, Branch) " +
                            "VALUES (@Title, @Author, @Genre, @ISBN, @Status, @Branch)";
                        MySqlCommand cmd = new MySqlCommand(insertData, cnn);

                        int isbn = int.Parse(addbook_ISBN.Text.Trim());
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@Title", addbook_title.Text.Trim());
                        cmd.Parameters.AddWithValue("@Author", addbook_author.Text.Trim());
                        cmd.Parameters.AddWithValue("@Genre", addbook_genre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", addbook_status.Text.Trim());
                        cmd.Parameters.AddWithValue("@Branch", branchId); // Use the retrieved BranchID

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
            addbook_title.Text = "";
            addbook_author.Text = "";
            addbook_genre.Text = "";
            addbook_ISBN.Text = "";
            addbook_status.SelectedIndex = -1;
            addbook_branch.Text = "";
        }

        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                addbook_title.Text = row.Cells[1].Value.ToString();
                addbook_author.Text = row.Cells[2].Value.ToString();
                addbook_genre.Text = row.Cells[3].Value.ToString();
                addbook_ISBN.Text = row.Cells[4].Value.ToString();
                addbook_status.Text = row.Cells[5].Value.ToString();
                addbook_branch.Text = row.Cells[6].Value.ToString();
            }


        }

        private void addbook_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
