namespace LibraryMS
{
    partial class AddBooks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            addbook_clearBtn = new Button();
            addbook_addBtn = new Button();
            panel2 = new Panel();
            addbooks_pic = new PictureBox();
            label6 = new Label();
            addbook_ISBN = new TextBox();
            label5 = new Label();
            label4 = new Label();
            addbook_genre = new TextBox();
            addbook_author = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            addbook_branch = new ComboBox();
            addbook_status = new ComboBox();
            addbook_title = new TextBox();
            label8 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_pic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Location = new Point(19, 79);
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
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 28);
            label1.Name = "label1";
            label1.Size = new Size(127, 34);
            label1.TabIndex = 0;
            label1.Text = "All Books";
            // 
            // addbook_clearBtn
            // 
            addbook_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbook_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbook_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addbook_clearBtn.FlatStyle = FlatStyle.Flat;
            addbook_clearBtn.Font = new Font("Arial Narrow", 10F);
            addbook_clearBtn.ForeColor = Color.White;
            addbook_clearBtn.Location = new Point(161, 446);
            addbook_clearBtn.Name = "addbook_clearBtn";
            addbook_clearBtn.Size = new Size(112, 52);
            addbook_clearBtn.TabIndex = 13;
            addbook_clearBtn.Text = "CLEAR";
            addbook_clearBtn.UseVisualStyleBackColor = false;
            addbook_clearBtn.Click += addbook_clearBtn_Click;
            // 
            // addbook_addBtn
            // 
            addbook_addBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbook_addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbook_addBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addbook_addBtn.FlatStyle = FlatStyle.Flat;
            addbook_addBtn.Font = new Font("Arial Narrow", 10F);
            addbook_addBtn.ForeColor = Color.White;
            addbook_addBtn.Location = new Point(29, 446);
            addbook_addBtn.Name = "addbook_addBtn";
            addbook_addBtn.Size = new Size(112, 52);
            addbook_addBtn.TabIndex = 12;
            addbook_addBtn.Text = "ADD";
            addbook_addBtn.UseVisualStyleBackColor = false;
            addbook_addBtn.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(314, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 530);
            panel2.TabIndex = 3;
            // 
            // addbooks_pic
            // 
            addbooks_pic.BackColor = SystemColors.ButtonHighlight;
            addbooks_pic.Image = (Image)resources.GetObject("addbooks_pic.Image");
            addbooks_pic.Location = new Point(76, 19);
            addbooks_pic.Name = "addbooks_pic";
            addbooks_pic.Size = new Size(117, 104);
            addbooks_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            addbooks_pic.TabIndex = 11;
            addbooks_pic.TabStop = false;
            addbooks_pic.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(10, 379);
            label6.Name = "label6";
            label6.Size = new Size(78, 24);
            label6.TabIndex = 10;
            label6.Text = "Branch:";
            label6.Click += label6_Click;
            // 
            // addbook_ISBN
            // 
            addbook_ISBN.Location = new Point(99, 284);
            addbook_ISBN.Name = "addbook_ISBN";
            addbook_ISBN.Size = new Size(185, 31);
            addbook_ISBN.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(31, 170);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 8;
            label5.Text = "Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 244);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 6;
            label4.Text = "Genre:";
            // 
            // addbook_genre
            // 
            addbook_genre.Location = new Point(99, 244);
            addbook_genre.Name = "addbook_genre";
            addbook_genre.Size = new Size(185, 31);
            addbook_genre.TabIndex = 3;
            // 
            // addbook_author
            // 
            addbook_author.Location = new Point(99, 200);
            addbook_author.Name = "addbook_author";
            addbook_author.Size = new Size(185, 31);
            addbook_author.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 331);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(addbook_branch);
            panel1.Controls.Add(addbook_status);
            panel1.Controls.Add(addbook_title);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addbook_clearBtn);
            panel1.Controls.Add(addbook_addBtn);
            panel1.Controls.Add(addbooks_pic);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addbook_ISBN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addbook_genre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addbook_author);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(9, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 530);
            panel1.TabIndex = 2;
            // 
            // addbook_branch
            // 
            addbook_branch.FormattingEnabled = true;
            addbook_branch.Items.AddRange(new object[] { "Dokki", "Haram", "October", "Maadi", "Korba" });
            addbook_branch.Location = new Point(99, 379);
            addbook_branch.Name = "addbook_branch";
            addbook_branch.Size = new Size(185, 33);
            addbook_branch.TabIndex = 19;
            // 
            // addbook_status
            // 
            addbook_status.FormattingEnabled = true;
            addbook_status.Items.AddRange(new object[] { "Available", "Borrowed", "Requested" });
            addbook_status.Location = new Point(99, 331);
            addbook_status.Name = "addbook_status";
            addbook_status.Size = new Size(185, 33);
            addbook_status.TabIndex = 18;
            // 
            // addbook_title
            // 
            addbook_title.Location = new Point(99, 163);
            addbook_title.Name = "addbook_title";
            addbook_title.Size = new Size(185, 31);
            addbook_title.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 207);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 17;
            label8.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 284);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 4;
            label3.Text = "ISBN:";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddBooks";
            Size = new Size(880, 565);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_pic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button addbook_clearBtn;
        private Button addbook_addBtn;
        private Panel panel2;
        private PictureBox addbooks_pic;
        private Label label6;
        private TextBox addbook_ISBN;
        private Label label5;
        private Label label4;
        private TextBox addbook_genre;
        private TextBox addbook_author;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox addbook_title;
        private Label label8;
        private ComboBox addbook_status;
        private ComboBox addbook_branch;
    }
}
