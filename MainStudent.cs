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
    public partial class MainStudent : Form
    {
        public MainStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            requestBooks1.Visible = false;
            issueBooks1.Visible = false;
            returnBooks1.Visible = false;
            reviewBooks1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            requestBooks1.Visible = true;
            issueBooks1.Visible = false;
            returnBooks1.Visible = false;
            reviewBooks1.Visible = false;
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

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            requestBooks1.Visible = false;
            issueBooks1.Visible = false;
            returnBooks1.Visible = false;
            reviewBooks1.Visible = true;
            fines1.Visible = false;
        }

        private void issuebooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            requestBooks1.Visible = false;
            issueBooks1.Visible = true;
            returnBooks1.Visible = false;
            reviewBooks1.Visible = false;
            fines1.Visible = false;
        }

        private void returnbooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            requestBooks1.Visible = false;
            issueBooks1.Visible = false;
            returnBooks1.Visible = true;
            reviewBooks1.Visible = false;
            fines1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            requestBooks1.Visible = false;
            issueBooks1.Visible = false;
            returnBooks1.Visible = false;
            reviewBooks1.Visible = false;
            fines1.Visible = true;
        }
    }
}
