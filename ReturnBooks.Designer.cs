namespace LibraryMS
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label8 = new Label();
            returnbooks_returndate = new DateTimePicker();
            returnbooks_clearBtn = new Button();
            returnbooks_returnBtn = new Button();
            pictureBox1 = new PictureBox();
            returnbooks_author = new TextBox();
            label6 = new Label();
            returnbooks_name = new TextBox();
            label5 = new Label();
            returnbooks_title = new TextBox();
            label4 = new Label();
            returnbooks_ID = new TextBox();
            label3 = new Label();
            returnbooks_issueID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(returnbooks_returndate);
            panel1.Controls.Add(returnbooks_clearBtn);
            panel1.Controls.Add(returnbooks_returnBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(returnbooks_author);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(returnbooks_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(returnbooks_title);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(returnbooks_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(returnbooks_issueID);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 530);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 401);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 28;
            label8.Text = "Return:";
            // 
            // returnbooks_returndate
            // 
            returnbooks_returndate.Location = new Point(99, 396);
            returnbooks_returndate.Name = "returnbooks_returndate";
            returnbooks_returndate.Size = new Size(207, 31);
            returnbooks_returndate.TabIndex = 27;
            // 
            // returnbooks_clearBtn
            // 
            returnbooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            returnbooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            returnbooks_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            returnbooks_clearBtn.FlatStyle = FlatStyle.Flat;
            returnbooks_clearBtn.Font = new Font("Arial Narrow", 10F);
            returnbooks_clearBtn.ForeColor = Color.White;
            returnbooks_clearBtn.Location = new Point(161, 446);
            returnbooks_clearBtn.Name = "returnbooks_clearBtn";
            returnbooks_clearBtn.Size = new Size(112, 52);
            returnbooks_clearBtn.TabIndex = 13;
            returnbooks_clearBtn.Text = "CLEAR";
            returnbooks_clearBtn.UseVisualStyleBackColor = false;
            returnbooks_clearBtn.Click += returnbooks_clearBtn_Click;
            // 
            // returnbooks_returnBtn
            // 
            returnbooks_returnBtn.BackColor = Color.FromArgb(14, 128, 87);
            returnbooks_returnBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            returnbooks_returnBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            returnbooks_returnBtn.FlatStyle = FlatStyle.Flat;
            returnbooks_returnBtn.Font = new Font("Arial Narrow", 10F);
            returnbooks_returnBtn.ForeColor = Color.White;
            returnbooks_returnBtn.Location = new Point(29, 446);
            returnbooks_returnBtn.Name = "returnbooks_returnBtn";
            returnbooks_returnBtn.Size = new Size(112, 52);
            returnbooks_returnBtn.TabIndex = 12;
            returnbooks_returnBtn.Text = "RETURN";
            returnbooks_returnBtn.UseVisualStyleBackColor = false;
            returnbooks_returnBtn.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // returnbooks_author
            // 
            returnbooks_author.Location = new Point(109, 333);
            returnbooks_author.Name = "returnbooks_author";
            returnbooks_author.Size = new Size(185, 31);
            returnbooks_author.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 340);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 10;
            label6.Text = "Author:";
            label6.Click += label6_Click;
            // 
            // returnbooks_name
            // 
            returnbooks_name.Location = new Point(109, 236);
            returnbooks_name.Name = "returnbooks_name";
            returnbooks_name.Size = new Size(185, 31);
            returnbooks_name.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 282);
            label5.Name = "label5";
            label5.Size = new Size(107, 24);
            label5.TabIndex = 8;
            label5.Text = "Book Title:";
            // 
            // returnbooks_title
            // 
            returnbooks_title.Location = new Point(109, 282);
            returnbooks_title.Name = "returnbooks_title";
            returnbooks_title.Size = new Size(185, 31);
            returnbooks_title.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(55, 196);
            label4.Name = "label4";
            label4.Size = new Size(38, 24);
            label4.TabIndex = 6;
            label4.Text = "ID:";
            // 
            // returnbooks_ID
            // 
            returnbooks_ID.Location = new Point(109, 196);
            returnbooks_ID.Name = "returnbooks_ID";
            returnbooks_ID.Size = new Size(185, 31);
            returnbooks_ID.TabIndex = 3;
            returnbooks_ID.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(24, 236);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // returnbooks_issueID
            // 
            returnbooks_issueID.Location = new Point(109, 152);
            returnbooks_issueID.Name = "returnbooks_issueID";
            returnbooks_issueID.Size = new Size(185, 31);
            returnbooks_issueID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(2, 159);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 2;
            label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(320, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 530);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 128, 87);
            dataGridViewCellStyle1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(17, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(518, 429);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(218, 34);
            label1.TabIndex = 0;
            label1.Text = "All Issued Books";
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReturnBooks";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox returnbooks_issueID;
        private Label label2;
        private TextBox returnbooks_ID;
        private Label label3;
        private TextBox returnbooks_title;
        private Label label4;
        private TextBox returnbooks_name;
        private Label label5;
        private TextBox returnbooks_author;
        private Label label6;
        private Button returnbooks_returnBtn;
        private PictureBox pictureBox1;
        private Button returnbooks_clearBtn;
        private Label label8;
        private DateTimePicker returnbooks_returndate;
        private DataGridView dataGridView1;
    }
}
