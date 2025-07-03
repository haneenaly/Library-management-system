namespace LibraryMS
{
    partial class dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            panel4 = new Panel();
            requestedbooks = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel3 = new Panel();
            issuedbooks = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            availablebooks = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 186);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 128, 87);
            panel4.Controls.Add(requestedbooks);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(587, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 150);
            panel4.TabIndex = 2;
            // 
            // requestedbooks
            // 
            requestedbooks.AutoSize = true;
            requestedbooks.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestedbooks.ForeColor = Color.White;
            requestedbooks.Location = new Point(197, 90);
            requestedbooks.Name = "requestedbooks";
            requestedbooks.Size = new Size(42, 48);
            requestedbooks.TabIndex = 2;
            requestedbooks.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 61);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 17);
            label6.Name = "label6";
            label6.Size = new Size(196, 29);
            label6.TabIndex = 0;
            label6.Text = "Requested Books";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 128, 87);
            panel3.Controls.Add(issuedbooks);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(302, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 150);
            panel3.TabIndex = 1;
            // 
            // issuedbooks
            // 
            issuedbooks.AutoSize = true;
            issuedbooks.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuedbooks.ForeColor = Color.White;
            issuedbooks.Location = new Point(197, 90);
            issuedbooks.Name = "issuedbooks";
            issuedbooks.Size = new Size(42, 48);
            issuedbooks.TabIndex = 2;
            issuedbooks.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(77, 17);
            label4.Name = "label4";
            label4.Size = new Size(154, 29);
            label4.TabIndex = 0;
            label4.Text = "Issued Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 128, 87);
            panel2.Controls.Add(availablebooks);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 150);
            panel2.TabIndex = 0;
            // 
            // availablebooks
            // 
            availablebooks.AutoSize = true;
            availablebooks.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availablebooks.ForeColor = Color.White;
            availablebooks.Location = new Point(197, 90);
            availablebooks.Name = "availablebooks";
            availablebooks.Size = new Size(42, 48);
            availablebooks.TabIndex = 2;
            availablebooks.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 17);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 0;
            label1.Text = "Available Books";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "dashboard";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Label requestedbooks;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel3;
        private Label issuedbooks;
        private PictureBox pictureBox2;
        private Label label4;
        private Label availablebooks;
    }
}
