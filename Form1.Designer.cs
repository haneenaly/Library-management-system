namespace LibraryMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            load = new Panel();
            Books = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Books).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 166);
            label1.Name = "label1";
            label1.Size = new Size(407, 37);
            label1.TabIndex = 0;
            label1.Text = "Library Managment System";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(load);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 20);
            panel1.TabIndex = 2;
            // 
            // load
            // 
            load.BackColor = Color.White;
            load.Location = new Point(0, 0);
            load.Name = "load";
            load.Size = new Size(50, 20);
            load.TabIndex = 3;
            // 
            // Books
            // 
            Books.Image = (Image)resources.GetObject("Books.Image");
            Books.Location = new Point(225, 50);
            Books.Name = "Books";
            Books.Size = new Size(100, 100);
            Books.SizeMode = PictureBoxSizeMode.StretchImage;
            Books.TabIndex = 3;
            Books.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 128, 87);
            ClientSize = new Size(575, 350);
            Controls.Add(Books);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel load;
        private PictureBox Books;
        private System.Windows.Forms.Timer timer1;
    }
}
