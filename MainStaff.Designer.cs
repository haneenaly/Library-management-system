namespace LibraryMS
{
    partial class MainStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStaff));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            logout_btn = new Button();
            updatebooks_btn = new Button();
            deletebooks_btn = new Button();
            addbooks_btn = new Button();
            requestbooks_btn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            requestedBooks1 = new RequestedBooks();
            updateBooks1 = new UpdateBooks();
            deleteBooks1 = new DeleteBooks();
            addBooks1 = new AddBooks();
            dashboard1 = new dashboard();
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
            panel1.Size = new Size(1149, 35);
            panel1.TabIndex = 3;
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
            label1.Location = new Point(1118, 6);
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
            panel3.Controls.Add(logout_btn);
            panel3.Controls.Add(updatebooks_btn);
            panel3.Controls.Add(deletebooks_btn);
            panel3.Controls.Add(addbooks_btn);
            panel3.Controls.Add(requestbooks_btn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 569);
            panel3.TabIndex = 4;
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
            logout_btn.Location = new Point(11, 506);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(223, 45);
            logout_btn.TabIndex = 6;
            logout_btn.Text = "SIGN OUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // updatebooks_btn
            // 
            updatebooks_btn.Cursor = Cursors.Hand;
            updatebooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            updatebooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            updatebooks_btn.FlatStyle = FlatStyle.Flat;
            updatebooks_btn.ForeColor = Color.White;
            updatebooks_btn.Image = (Image)resources.GetObject("updatebooks_btn.Image");
            updatebooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            updatebooks_btn.Location = new Point(10, 410);
            updatebooks_btn.Name = "updatebooks_btn";
            updatebooks_btn.Size = new Size(224, 45);
            updatebooks_btn.TabIndex = 5;
            updatebooks_btn.Text = "UPDATE BOOKS\r\n\r\n";
            updatebooks_btn.UseVisualStyleBackColor = true;
            updatebooks_btn.Click += updatebooks_btn_Click;
            // 
            // deletebooks_btn
            // 
            deletebooks_btn.Cursor = Cursors.Hand;
            deletebooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            deletebooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            deletebooks_btn.FlatStyle = FlatStyle.Flat;
            deletebooks_btn.ForeColor = Color.White;
            deletebooks_btn.Image = (Image)resources.GetObject("deletebooks_btn.Image");
            deletebooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            deletebooks_btn.Location = new Point(10, 332);
            deletebooks_btn.Name = "deletebooks_btn";
            deletebooks_btn.Size = new Size(224, 45);
            deletebooks_btn.TabIndex = 4;
            deletebooks_btn.Text = "DELETE BOOKS";
            deletebooks_btn.UseVisualStyleBackColor = true;
            deletebooks_btn.Click += deletebooks_btn_Click;
            // 
            // addbooks_btn
            // 
            addbooks_btn.Cursor = Cursors.Hand;
            addbooks_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbooks_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addbooks_btn.FlatStyle = FlatStyle.Flat;
            addbooks_btn.ForeColor = Color.White;
            addbooks_btn.Image = (Image)resources.GetObject("addbooks_btn.Image");
            addbooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addbooks_btn.Location = new Point(10, 258);
            addbooks_btn.Name = "addbooks_btn";
            addbooks_btn.Size = new Size(224, 45);
            addbooks_btn.TabIndex = 3;
            addbooks_btn.Text = "ADD BOOKS";
            addbooks_btn.UseVisualStyleBackColor = true;
            addbooks_btn.Click += addbooks_btn_Click;
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
            requestbooks_btn.Location = new Point(11, 186);
            requestbooks_btn.Name = "requestbooks_btn";
            requestbooks_btn.Size = new Size(223, 45);
            requestbooks_btn.TabIndex = 2;
            requestbooks_btn.Text = "REQUESTED BOOKS";
            requestbooks_btn.UseVisualStyleBackColor = true;
            requestbooks_btn.Click += requestbooks_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 128);
            label3.Name = "label3";
            label3.Size = new Size(139, 29);
            label3.TabIndex = 1;
            label3.Text = "WELCOME!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(requestedBooks1);
            panel4.Controls.Add(updateBooks1);
            panel4.Controls.Add(deleteBooks1);
            panel4.Controls.Add(addBooks1);
            panel4.Controls.Add(dashboard1);
            panel4.Location = new Point(256, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(886, 582);
            panel4.TabIndex = 5;
            // 
            // requestedBooks1
            // 
            requestedBooks1.Location = new Point(3, -1);
            requestedBooks1.Name = "requestedBooks1";
            requestedBooks1.Size = new Size(1320, 848);
            requestedBooks1.TabIndex = 8;
            // 
            // updateBooks1
            // 
            updateBooks1.Location = new Point(0, 0);
            updateBooks1.Name = "updateBooks1";
            updateBooks1.Size = new Size(1320, 848);
            updateBooks1.TabIndex = 7;
            // 
            // deleteBooks1
            // 
            deleteBooks1.Location = new Point(3, 0);
            deleteBooks1.Name = "deleteBooks1";
            deleteBooks1.Size = new Size(1320, 848);
            deleteBooks1.TabIndex = 6;
            // 
            // addBooks1
            // 
            addBooks1.Location = new Point(3, 0);
            addBooks1.Name = "addBooks1";
            addBooks1.Size = new Size(1320, 848);
            addBooks1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(3, -1);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1320, 848);
            dashboard1.TabIndex = 0;
            // 
            // MainStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 605);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainStaff";
            Text = "MainStaff";
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
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button logout_btn;
        private Button updatebooks_btn;
        private Button deletebooks_btn;
        private Button addbooks_btn;
        private Button requestbooks_btn;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private AddBooks addBooks1;
        private dashboard dashboard1;
        private UpdateBooks updateBooks1;
        private DeleteBooks deleteBooks1;
        private RequestedBooks requestedBooks1;
    }
}