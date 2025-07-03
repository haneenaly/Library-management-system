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
    public partial class IssueBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;

        int ID { get; set; }

        public IssueBooks()
        {
            InitializeComponent();

            cnn = new MySqlConnection(connectionString);

            displayBooks();
        }

        public void clearFields()
        {
            issueBooks_title.Text = "";
            issueBooks_author.Text = "";
            issueBooks_issueID.Text = "";
            issueBooks_ID.Text = "";
            issueBooks_name.Text = "";
            issueBooks_issuedate.Value = DateTime.Now;
        }

        public void displayBooks()
        {
            availablebooks dab = new availablebooks();
            List<availablebooks> listData = dab.availableBooksData();

            dataGridView1.DataSource = listData;
        }

        private void issueBooks_issueBtn_Click(object sender, EventArgs e)
        {
            if (issueBooks_title.Text == ""
               || issueBooks_author.Text == ""
               || issueBooks_issueID.Text == ""
               || issueBooks_ID.Text == ""
               || issueBooks_name.Text == ""
                )
            {
                MessageBox.Show("Please select item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to ISSUE book ID:" +
                    ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();

                        string updatetransaction = "INSERT INTO transaction SET TransactionID = @issueID, MemberID = @memberID, BookID = @BookID, BorrowDate = @issuedate ";

                        using (MySqlCommand cmd1 = new MySqlCommand(updatetransaction, cnn))
                        {
                            cmd1.Parameters.AddWithValue("@issueID", issueBooks_issueID.Text);
                            cmd1.Parameters.AddWithValue("@memberID", issueBooks_ID.Text);
                            cmd1.Parameters.AddWithValue("@BookID", ID);
                            cmd1.Parameters.AddWithValue("@issuedate", issueBooks_issuedate.Value);

                            int rowsAffected = cmd1.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                string updateData = "UPDATE book SET Status = 'borrowed' WHERE BookID = @BookID";

                                using (MySqlCommand cmd = new MySqlCommand(updateData, cnn))
                                {

                                    cmd.Parameters.AddWithValue("@BookID", ID);

                                    int rowsAffected1 = cmd.ExecuteNonQuery();
                                    if (rowsAffected1 > 0)
                                    {
                                        MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        displayBooks(); // Refresh the book list after issuing
                                        clearFields();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No books were issued. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
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

        private void issueBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                ID = (int)row.Cells[0].Value;
                issueBooks_title.Text = row.Cells[1].Value.ToString();
                issueBooks_author.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
