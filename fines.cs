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
    public partial class fines : UserControl
    {
        string connectionString = "server=localhost; database=Library; uid=root; pwd=haneen2004;";
        MySqlConnection cnn;
        int ID { get; set; }
        public fines()
        {
            InitializeComponent();

            cnn = new MySqlConnection(connectionString);
        }

        private void dashbord_btn_Click(object sender, EventArgs e)
        {
            if (fines_memberID.Text == ""
                           || fines_transactionID.Text == ""
                           || fines_fine.Text == ""
                            )
            {
                MessageBox.Show("Please enter all fields first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else
            //{
            //    DialogResult check = MessageBox.Show("Are you sure you want to PAY this fine:" +
            //        ID + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (check == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            cnn.Open();

            //            string updatetransaction = "UPDATE transaction SET ReturnDate = @returndate WHERE BookID = @BookID";

            //            using (MySqlCommand cmd1 = new MySqlCommand(updatetransaction, cnn))
            //            {
            //                cmd1.Parameters.AddWithValue("@BookID", ID);
            //                cmd1.Parameters.AddWithValue("@returndate", returnbooks_returndate.Value);

            //                int rowsAffected = cmd1.ExecuteNonQuery();
            //                if (rowsAffected > 0)
            //                {
            //                    string updateData = "UPDATE book SET Status = 'available' WHERE BookID = @BookID";

            //                    using (MySqlCommand cmd = new MySqlCommand(updateData, cnn))
            //                    {

            //                        cmd.Parameters.AddWithValue("@BookID", ID);

            //                        int rowsAffected1 = cmd.ExecuteNonQuery();
            //                        if (rowsAffected1 > 0)
            //                        {
            //                            MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                            displayBooks(); // Refresh the book list after issuing
            //                            clearFields();
            //                        }
            //                        else
            //                        {
            //                            MessageBox.Show("No books were returned. Please ensure the BookID exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            cnn.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }


            //}
        }
    }
}
