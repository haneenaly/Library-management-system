namespace LibraryMS
{
    partial class fines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fines));
            panel1 = new Panel();
            dashbord_btn = new Button();
            label1 = new Label();
            fines_memberID = new TextBox();
            label2 = new Label();
            fines_fine = new TextBox();
            pictureBox1 = new PictureBox();
            fines_transactionID = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(fines_transactionID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(fines_fine);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fines_memberID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dashbord_btn);
            panel1.Location = new Point(24, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 520);
            panel1.TabIndex = 0;
            // 
            // dashbord_btn
            // 
            dashbord_btn.BackColor = Color.FromArgb(14, 128, 87);
            dashbord_btn.Cursor = Cursors.Hand;
            dashbord_btn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            dashbord_btn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            dashbord_btn.FlatStyle = FlatStyle.Flat;
            dashbord_btn.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashbord_btn.ForeColor = Color.White;
            dashbord_btn.Location = new Point(538, 417);
            dashbord_btn.Name = "dashbord_btn";
            dashbord_btn.Size = new Size(182, 58);
            dashbord_btn.TabIndex = 3;
            dashbord_btn.Text = "PAY";
            dashbord_btn.UseVisualStyleBackColor = false;
            dashbord_btn.Click += dashbord_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 45);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 4;
            label1.Text = "Your ID:";
            // 
            // fines_memberID
            // 
            fines_memberID.Location = new Point(112, 89);
            fines_memberID.Name = "fines_memberID";
            fines_memberID.Size = new Size(283, 31);
            fines_memberID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 132);
            label2.Name = "label2";
            label2.Size = new Size(76, 29);
            label2.TabIndex = 6;
            label2.Text = "Fines:";
            // 
            // fines_fine
            // 
            fines_fine.Location = new Point(112, 177);
            fines_fine.Name = "fines_fine";
            fines_fine.Size = new Size(285, 31);
            fines_fine.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // fines_transactionID
            // 
            fines_transactionID.Location = new Point(112, 299);
            fines_transactionID.Name = "fines_transactionID";
            fines_transactionID.Size = new Size(285, 31);
            fines_transactionID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 236);
            label3.Name = "label3";
            label3.Size = new Size(177, 29);
            label3.TabIndex = 9;
            label3.Text = "Transaction ID:";
            // 
            // fines
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "fines";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox fines_memberID;
        private Label label1;
        private Button dashbord_btn;
        private TextBox fines_transactionID;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox fines_fine;
        private Label label2;
    }
}
