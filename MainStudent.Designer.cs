
namespace LibraryMS
{
    partial class MainStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStudent));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            addreview_btn = new Button();
            logout_btn = new Button();
            returnbooks_btn = new Button();
            issuebooks_btn = new Button();
            requestbooks_btn = new Button();
            dashbord_btn = new Button();
            great_label = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            reviewBooks1 = new ReviewBooks();
            returnBooks1 = new ReturnBooks();
            issueBooks1 = new IssueBooks();
            requestBooks1 = new RequestBooks();
            dashboard1 = new dashboard();
            fines1 = new fines();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 35);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 511);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(202, 27);
            label2.TabIndex = 1;
            label2.Text = "Library | Main Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1105, 5);
            label1.Name = "label1";
            label1.Size = new Size(24, 26);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 128, 87);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(addreview_btn);
            panel3.Controls.Add(logout_btn);
            panel3.Controls.Add(returnbooks_btn);
            panel3.Controls.Add(issuebooks_btn);
            panel3.Controls.Add(requestbooks_btn);
            panel3.Controls.Add(dashbord_btn);
            panel3.Controls.Add(great_label);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 577);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 432);
            button1.Name = "button1";
            button1.Size = new Size(224, 45);
            button1.TabIndex = 8;
            button1.Text = "FINES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // addreview_btn
            // 
            addreview_btn.Cursor = Cursors.Hand;
            addreview_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addreview_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addreview_btn.FlatStyle = FlatStyle.Flat;
            addreview_btn.ForeColor = Color.White;
            addreview_btn.Image = (Image)resources.GetObject("addreview_btn.Image");
            addreview_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addreview_btn.Location = new Point(10, 370);
            addreview_btn.Name = "addreview_btn";
            addreview_btn.Size = new Size(224, 45);
            addreview_btn.TabIndex = 7;
            addreview_btn.Text = "REVIEWS";
            addreview_btn.UseVisualStyleBackColor = true;
            addreview_btn.Click += button5_Click;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(11, 516);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(208, 45);
            logout_btn.TabIndex = 6;
            logout_btn.Text = "SIGN OUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // returnbooks_btn
            // 
            returnbooks_btn.Cursor = Cursors.Hand;
            returnbooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            returnbooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            returnbooks_btn.FlatStyle = FlatStyle.Flat;
            returnbooks_btn.ForeColor = Color.White;
            returnbooks_btn.Image = (Image)resources.GetObject("returnbooks_btn.Image");
            returnbooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            returnbooks_btn.Location = new Point(12, 309);
            returnbooks_btn.Name = "returnbooks_btn";
            returnbooks_btn.Size = new Size(224, 45);
            returnbooks_btn.TabIndex = 5;
            returnbooks_btn.Text = "RETURN BOOKS";
            returnbooks_btn.UseVisualStyleBackColor = true;
            returnbooks_btn.Click += returnbooks_btn_Click;
            // 
            // issuebooks_btn
            // 
            issuebooks_btn.Cursor = Cursors.Hand;
            issuebooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issuebooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            issuebooks_btn.FlatStyle = FlatStyle.Flat;
            issuebooks_btn.ForeColor = Color.White;
            issuebooks_btn.Image = (Image)resources.GetObject("issuebooks_btn.Image");
            issuebooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            issuebooks_btn.Location = new Point(11, 247);
            issuebooks_btn.Name = "issuebooks_btn";
            issuebooks_btn.Size = new Size(224, 45);
            issuebooks_btn.TabIndex = 4;
            issuebooks_btn.Text = "ISSUE BOOKS";
            issuebooks_btn.UseVisualStyleBackColor = true;
            issuebooks_btn.Click += issuebooks_btn_Click;
            // 
            // requestbooks_btn
            // 
            requestbooks_btn.Cursor = Cursors.Hand;
            requestbooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            requestbooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            requestbooks_btn.FlatStyle = FlatStyle.Flat;
            requestbooks_btn.ForeColor = Color.White;
            requestbooks_btn.Image = (Image)resources.GetObject("requestbooks_btn.Image");
            requestbooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            requestbooks_btn.Location = new Point(10, 187);
            requestbooks_btn.Name = "requestbooks_btn";
            requestbooks_btn.Size = new Size(224, 45);
            requestbooks_btn.TabIndex = 3;
            requestbooks_btn.Text = "REQUEST BOOKS";
            requestbooks_btn.UseVisualStyleBackColor = true;
            requestbooks_btn.Click += button2_Click;
            // 
            // dashbord_btn
            // 
            dashbord_btn.Cursor = Cursors.Hand;
            dashbord_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            dashbord_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            dashbord_btn.FlatStyle = FlatStyle.Flat;
            dashbord_btn.ForeColor = Color.White;
            dashbord_btn.Location = new Point(12, 125);
            dashbord_btn.Name = "dashbord_btn";
            dashbord_btn.Size = new Size(223, 45);
            dashbord_btn.TabIndex = 2;
            dashbord_btn.Text = "DASHBOARD";
            dashbord_btn.UseVisualStyleBackColor = true;
            dashbord_btn.Click += button1_Click;
            // 
            // great_label
            // 
            great_label.AutoSize = true;
            great_label.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            great_label.ForeColor = Color.White;
            great_label.Location = new Point(98, 40);
            great_label.Name = "great_label";
            great_label.Size = new Size(154, 29);
            great_label.TabIndex = 1;
            great_label.Text = "WELCOME, !!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(fines1);
            panel4.Controls.Add(reviewBooks1);
            panel4.Controls.Add(returnBooks1);
            panel4.Controls.Add(issueBooks1);
            panel4.Controls.Add(requestBooks1);
            panel4.Controls.Add(dashboard1);
            panel4.Location = new Point(259, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(870, 577);
            panel4.TabIndex = 2;
            // 
            // reviewBooks1
            // 
            reviewBooks1.Location = new Point(0, 0);
            reviewBooks1.Name = "reviewBooks1";
            reviewBooks1.Size = new Size(1320, 848);
            reviewBooks1.TabIndex = 4;
            // 
            // returnBooks1
            // 
            returnBooks1.Location = new Point(0, 0);
            returnBooks1.Name = "returnBooks1";
            returnBooks1.Size = new Size(1320, 848);
            returnBooks1.TabIndex = 3;
            // 
            // issueBooks1
            // 
            issueBooks1.Location = new Point(0, 0);
            issueBooks1.Name = "issueBooks1";
            issueBooks1.Size = new Size(1320, 848);
            issueBooks1.TabIndex = 2;
            // 
            // requestBooks1
            // 
            requestBooks1.Location = new Point(0, 0);
            requestBooks1.Name = "requestBooks1";
            requestBooks1.Size = new Size(1320, 848);
            requestBooks1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 1);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(880, 565);
            dashboard1.TabIndex = 0;
            // 
            // fines1
            // 
            fines1.Location = new Point(0, 0);
            fines1.Name = "fines1";
            fines1.Size = new Size(1320, 848);
            fines1.TabIndex = 5;
            // 
            // MainStudent
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1144, 612);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label great_label;
        private Button requestbooks_btn;
        private Button dashbord_btn;
        private Button returnbooks_btn;
        private Button issuebooks_btn;
        private Button logout_btn;
        private Panel panel4;
        private Button addreview_btn;
        private dashboard dashboard1;
        private ReviewBooks reviewBooks1;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
        private RequestBooks requestBooks1;
        private Button button1;
        private fines fines1;
    }
}