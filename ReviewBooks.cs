using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryMS
{
    public partial class ReviewBooks : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;

        int ID { get; set; }

        public ReviewBooks()
        {
            InitializeComponent();

            cnn = new MySqlConnection(connectionString);

            displayBooks();
        }

        public void clearFields()
        {
            addReview_ID.Text = "";
            addReview_review.Text = "";

        }
        public void displayBooks()
        {
            availablebooks dab = new availablebooks();
            List<availablebooks> listData = dab.availableBooksData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                ID = (int)row.Cells[0].Value;
                addReview_book.Text = (string)row.Cells[1].Value;
                bookReview_book.Text = (string)row.Cells[1].Value;
            }

            try
            {
                cnn.Open();


                string reviews = "SELECT MemberID,Review FROM reviews WHERE BookID = @BookID";
                MySqlCommand reviewscmd = new MySqlCommand(reviews, cnn);
                reviewscmd.Parameters.AddWithValue("@BookID", ID);


                using (MySqlDataReader reader = reviewscmd.ExecuteReader())
                {
                    // Check if there are rows in the result
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Display or process the MemberID and Review
                            string memberId = reader["MemberID"].ToString();
                            string reviewText = reader["Review"].ToString();

                            // Assign to UI fields or process the data
                            bookReview_name.Text = memberId;   // Assuming MemberID corresponds to the name field
                            bookReview_review.Text = reviewText;
                        }
                    }
                    else
                    {
                        bookReview_review.Text = "No reviews found for the specified BookID.";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
            
            }


            }

        private void addReview_addBtn_Click(object sender, EventArgs e)
        {
            if (addReview_ID.Text == ""
               || addReview_review.Text == ""
                )
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to ADD REVIEW for book ID:" +
                    ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();

                        string updatetransaction = "INSERT INTO reviews SET Review = @review, MemberID = @memberID, BookID = @BookID ";

                        using (MySqlCommand cmd1 = new MySqlCommand(updatetransaction, cnn))
                        {
                            cmd1.Parameters.AddWithValue("@review", addReview_review.Text);
                            cmd1.Parameters.AddWithValue("@memberID", addReview_ID.Text);
                            cmd1.Parameters.AddWithValue("@BookID", ID);

                            int rowsAffected = cmd1.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book review added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayBooks(); // Refresh the book list after the review
                                clearFields();
                            }

                            else
                            {
                                MessageBox.Show("No review was added. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void addReview_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
