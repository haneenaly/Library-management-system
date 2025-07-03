using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class MainStaff : Form
    {
        public MainStaff()
        {
            InitializeComponent();
        }

        private void requestbooks_btn_Click(object sender, EventArgs e)
        {
            requestedBooks1.Visible = true;
            addBooks1.Visible = false;
            deleteBooks1.Visible = false;
            updateBooks1.Visible = false;
        }

        private void addbooks_btn_Click(object sender, EventArgs e)
        {
            requestedBooks1.Visible = false;
            addBooks1.Visible = true;
            deleteBooks1.Visible = false;
            updateBooks1.Visible = false;
        }

        private void deletebooks_btn_Click(object sender, EventArgs e)
        {
            requestedBooks1.Visible = false;
            addBooks1.Visible = false;
            deleteBooks1.Visible = true;
            updateBooks1.Visible = false;
        }

        private void updatebooks_btn_Click(object sender, EventArgs e)
        {
            requestedBooks1.Visible = false;
            addBooks1.Visible = false;
            deleteBooks1.Visible = false;
            updateBooks1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login lform = new Login();
                lform.Show();
                this.Hide();
            }
        }
    }
}
