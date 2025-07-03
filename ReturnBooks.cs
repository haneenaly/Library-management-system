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
    public partial class ReturnBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;

        int ID { get; set; }
        public ReturnBooks()
        {
            InitializeComponent();

            cnn = new MySqlConnection(connectionString);

            displayBooks();
        }

        public void clearFields()
        {
            returnbooks_title.Text = "";
            returnbooks_author.Text = "";
            returnbooks_issueID.Text = "";
            returnbooks_ID.Text = "";
            returnbooks_name.Text = "";
            returnbooks_returndate.Value = DateTime.Now;
        }

        public void displayBooks()
        {
            issuedbooks dab = new issuedbooks();
            List<issuedbooks> listData = dab.issuedBooksData();

            dataGridView1.DataSource = listData;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (returnbooks_title.Text == ""
                           || returnbooks_author.Text == ""
                           || returnbooks_issueID.Text == ""
                           || returnbooks_ID.Text == ""
                           || returnbooks_name.Text == ""
                            )
            {
                MessageBox.Show("Please select item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to RETURN book ID:" +
                    ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();

                        string updatetransaction = "UPDATE transaction SET ReturnDate = @returndate WHERE BookID = @BookID";

                        using (MySqlCommand cmd1 = new MySqlCommand(updatetransaction, cnn))
                        {
                            cmd1.Parameters.AddWithValue("@BookID", ID);
                            cmd1.Parameters.AddWithValue("@returndate", returnbooks_returndate.Value);

                            int rowsAffected = cmd1.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                string updateData = "UPDATE book SET Status = 'available' WHERE BookID = @BookID";

                                using (MySqlCommand cmd = new MySqlCommand(updateData, cnn))
                                {
                                    cnn.Open();

                                    cmd.Parameters.AddWithValue("@BookID", ID);

                                    int rowsAffected1 = cmd.ExecuteNonQuery();
                                    if (rowsAffected1 > 0)
                                    {
                                        MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        displayBooks(); // Refresh the book list after issuing
                                        clearFields();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No books were returned. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                                string insertFineQuery = @"
                                                        INSERT INTO fine (TransactionID, fineAmount)
                                                        SELECT t.transactionID,b.BookID 
                                                               CASE
                                                                   WHEN DATEDIFF(t.ReturnDate, t.BorrowDate) > 14
                                                                   THEN (DATEDIFF(t.ReturnDate, t.BorrowDate) - 14) * 5
                                                                   ELSE 0
                                                               END AS fineAmount
                                                        FROM transaction t, book b
                                                        LEFT JOIN fine f ON t.TransactionID = f.TransactionID
                                                        WHERE BookID = @BookID ;";

                                try
                                {
                                    using (MySqlConnection cnn = new MySqlConnection(connectionString))
                                    {

                                        using (MySqlCommand cmd2 = new MySqlCommand(insertFineQuery, cnn))
                                        {
                                            cmd2.Parameters.AddWithValue("@BookID", ID);
                                            int rowsAffectedd = cmd2.ExecuteNonQuery();

                                            if (rowsAffectedd > 0)
                                            {
                                                MessageBox.Show($"{rowsAffected} fines have been successfully added.",
                                                                "Success",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("No fines were added. All transactions are already processed.",
                                                                "Info",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"An error occurred: {ex.Message}",
                                                    "Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                ID = (int)row.Cells[0].Value;
                returnbooks_title.Text = row.Cells[1].Value.ToString();
                returnbooks_author.Text = row.Cells[2].Value.ToString();
            }
        }
        private void returnbooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


    }
}
