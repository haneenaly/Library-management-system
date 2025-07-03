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

namespace LibraryMS
{
    public partial class UpdateBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;

        int ID { get; set; }

        public UpdateBooks()
        {
            InitializeComponent();

            displayBooks();

            cnn = new MySqlConnection(connectionString);
        }

        public void clearFields()
        {
            updatebooks_title.Text = "";
            updatebooks_author.Text = "";
            updatebooks_genre.Text = "";
            updatebooks_ISBN.Text = "";
            updatebooks_status.SelectedIndex = -1;
            updatebooks_branch.Text = "";
        }

        private void updatebooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void updatebooks_updateBtn_Click(object sender, EventArgs e)
        {

            if (updatebooks_title.Text == ""
               || updatebooks_author.Text == ""
               || updatebooks_genre.Text == ""
               || updatebooks_ISBN.Text == ""
               || updatebooks_status.Text == ""
               || updatebooks_branch.Text == ""
                )
            {
                MessageBox.Show("Please select item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE book ID:" +
                    ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();

                        string updateData = "UPDATE book SET Title = @Title, Author = @Author, Genre = @Genre, " +
                                "ISBN = @ISBN, Status = @Status, Branch = @Branch WHERE BookID = @BookID";

                        using (MySqlCommand cmd = new MySqlCommand(updateData, cnn))
                        {
                            cmd.Parameters.AddWithValue("@Title", updatebooks_title.Text);
                            cmd.Parameters.AddWithValue("@Author", updatebooks_author.Text);
                            cmd.Parameters.AddWithValue("@Genre", updatebooks_genre.Text);
                            cmd.Parameters.AddWithValue("@ISBN", updatebooks_ISBN.Text);
                            cmd.Parameters.AddWithValue("@Status", updatebooks_status.Text);
                            cmd.Parameters.AddWithValue("@Branch", updatebooks_branch.Text);
                            cmd.Parameters.AddWithValue("@BookID", ID);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayBooks(); // Refresh the book list after updating
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }

        }

        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                ID = (int)row.Cells[0].Value;
                updatebooks_title.Text = row.Cells[1].Value.ToString();
                updatebooks_author.Text = row.Cells[2].Value.ToString();
                updatebooks_genre.Text = row.Cells[3].Value.ToString();
                updatebooks_ISBN.Text = row.Cells[4].Value.ToString();
                updatebooks_status.Text = row.Cells[5].Value.ToString();
                updatebooks_branch.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
