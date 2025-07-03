namespace LibraryMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            login_username = new Label();
            login_password = new Label();
            login_user = new TextBox();
            login_pass = new TextBox();
            label4 = new Label();
            login_btn = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 84);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 26);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // login_username
            // 
            login_username.AutoSize = true;
            login_username.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(39, 224);
            login_username.Name = "login_username";
            login_username.Size = new Size(95, 26);
            login_username.TabIndex = 3;
            login_username.Text = "Username";
            // 
            // login_password
            // 
            login_password.AutoSize = true;
            login_password.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(39, 299);
            login_password.Name = "login_password";
            login_password.Size = new Size(91, 26);
            login_password.TabIndex = 4;
            login_password.Text = "Password";
            // 
            // login_user
            // 
            login_user.Location = new Point(39, 253);
            login_user.Name = "login_user";
            login_user.Size = new Size(251, 31);
            login_user.TabIndex = 5;
            // 
            // login_pass
            // 
            login_pass.Location = new Point(39, 328);
            login_pass.Name = "login_pass";
            login_pass.PasswordChar = '*';
            login_pass.Size = new Size(251, 31);
            login_pass.TabIndex = 6;
            login_pass.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 481);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(14, 128, 84);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(39, 398);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(251, 50);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 128, 84);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(59, 520);
            button2.Name = "button2";
            button2.Size = new Size(186, 43);
            button2.TabIndex = 9;
            button2.Text = "Register Here";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(329, 587);
            Controls.Add(button2);
            Controls.Add(login_btn);
            Controls.Add(label4);
            Controls.Add(login_pass);
            Controls.Add(login_user);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label login_username;
        private Label login_password;
        private TextBox login_user;
        private TextBox login_pass;
        private Label label4;
        private Button login_btn;
        private Button button2;
    }
}