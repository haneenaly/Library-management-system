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
    public partial class DeleteBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;
        int ID { get; set; }
        public DeleteBooks()
        {
            InitializeComponent();

            displayBooks();

            cnn = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deletebook_title.Text == ""
                          || deletebook_author.Text == ""
                          || deletebook_genre.Text == ""
                          || deletebook_ISBN.Text == ""
                          || deletebook_status.Text == ""
                          || deletebook_branch.Text == ""
                           )
            {
                MessageBox.Show("Please select item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE book ID:" +
                    ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();

                        string updateData = "DELETE FROM book WHERE BookID = "+ ID;

                        using (MySqlCommand cmd = new MySqlCommand(updateData, cnn))
                        {

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayBooks(); // Refresh the book list after deleting
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No rows were deleted. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    ID = (int)row.Cells[0].Value;
                    deletebook_title.Text = row.Cells[1].Value.ToString();
                    deletebook_author.Text = row.Cells[2].Value.ToString();
                    deletebook_genre.Text = row.Cells[3].Value.ToString();
                    deletebook_ISBN.Text = row.Cells[4].Value.ToString();
                    deletebook_status.Text = row.Cells[5].Value.ToString();
                    deletebook_branch.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        public void clearFields()
        {
            deletebook_title.Text = "";
            deletebook_author.Text = "";
            deletebook_genre.Text = "";
            deletebook_ISBN.Text = "";
            deletebook_status.SelectedIndex = -1;
            deletebook_branch.Text = "";
        }
    }
}
