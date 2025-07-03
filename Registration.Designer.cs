namespace LibraryMS
{
    partial class Registration
       
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            panel1 = new Panel();
            X = new Label();
            pictureBox1 = new PictureBox();
            Username = new Label();
            ID = new Label();
            Password = new Label();
            register_name = new TextBox();
            register_ID = new TextBox();
            register_password = new TextBox();
            Register = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 84);
            panel1.Controls.Add(X);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 38);
            panel1.TabIndex = 0;
            // 
            // X
            // 
            X.AutoSize = true;
            X.Cursor = Cursors.Hand;
            X.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            X.ForeColor = Color.White;
            X.Location = new Point(309, 9);
            X.Name = "X";
            X.Size = new Size(21, 24);
            X.TabIndex = 0;
            X.Text = "X";
            X.Click += X_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(35, 197);
            Username.Name = "Username";
            Username.Size = new Size(91, 25);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(35, 259);
            ID.Name = "ID";
            ID.Size = new Size(30, 25);
            ID.TabIndex = 3;
            ID.Text = "ID";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(35, 321);
            Password.Name = "Password";
            Password.Size = new Size(87, 25);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // register_name
            // 
            register_name.Location = new Point(35, 225);
            register_name.Name = "register_name";
            register_name.Size = new Size(251, 31);
            register_name.TabIndex = 5;
            // 
            // register_ID
            // 
            register_ID.Location = new Point(35, 287);
            register_ID.Name = "register_ID";
            register_ID.Size = new Size(251, 31);
            register_ID.TabIndex = 6;
            // 
            // register_password
            // 
            register_password.Location = new Point(35, 358);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(251, 31);
            register_password.TabIndex = 7;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(14, 128, 84);
            Register.Cursor = Cursors.Hand;
            Register.FlatAppearance.BorderSize = 0;
            Register.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            Register.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register.ForeColor = Color.White;
            Register.Location = new Point(35, 451);
            Register.Name = "Register";
            Register.RightToLeft = RightToLeft.Yes;
            Register.Size = new Size(251, 50);
            Register.TabIndex = 8;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(145, 395);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 26);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(329, 587);
            Controls.Add(checkBox1);
            Controls.Add(Register);
            Controls.Add(register_password);
            Controls.Add(register_ID);
            Controls.Add(register_name);
            Controls.Add(Password);
            Controls.Add(ID);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label X;
        private PictureBox pictureBox1;
        private Label Username;
        private Label ID;
        private Label Password;
        private TextBox register_name;
        private TextBox register_ID;
        private TextBox register_password;
        private Button Register;
        private CheckBox checkBox1;
    }
}