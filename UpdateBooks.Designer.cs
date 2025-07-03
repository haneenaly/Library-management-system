namespace LibraryMS
{
    partial class UpdateBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            updatebooks_branch = new ComboBox();
            updatebooks_status = new ComboBox();
            updatebooks_title = new TextBox();
            label8 = new Label();
            updatebooks_clearBtn = new Button();
            updatebooks_updateBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            updatebooks_ISBN = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            updatebooks_genre = new TextBox();
            label3 = new Label();
            updatebooks_author = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // updatebooks_branch
            // 
            updatebooks_branch.FormattingEnabled = true;
            updatebooks_branch.Items.AddRange(new object[] { "Dokki", "Haram", "October", "Maadi", "Korba" });
            updatebooks_branch.Location = new Point(99, 379);
            updatebooks_branch.Name = "updatebooks_branch";
            updatebooks_branch.Size = new Size(185, 33);
            updatebooks_branch.TabIndex = 19;
            // 
            // updatebooks_status
            // 
            updatebooks_status.FormattingEnabled = true;
            updatebooks_status.Items.AddRange(new object[] { "Available", "Borrowed", "Requested" });
            updatebooks_status.Location = new Point(99, 331);
            updatebooks_status.Name = "updatebooks_status";
            updatebooks_status.Size = new Size(185, 33);
            updatebooks_status.TabIndex = 18;
            // 
            // updatebooks_title
            // 
            updatebooks_title.Location = new Point(99, 163);
            updatebooks_title.Name = "updatebooks_title";
            updatebooks_title.Size = new Size(185, 31);
            updatebooks_title.TabIndex = 16;
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
            // updatebooks_clearBtn
            // 
            updatebooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            updatebooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            updatebooks_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            updatebooks_clearBtn.FlatStyle = FlatStyle.Flat;
            updatebooks_clearBtn.Font = new Font("Arial Narrow", 10F);
            updatebooks_clearBtn.ForeColor = Color.White;
            updatebooks_clearBtn.Location = new Point(161, 446);
            updatebooks_clearBtn.Name = "updatebooks_clearBtn";
            updatebooks_clearBtn.Size = new Size(112, 52);
            updatebooks_clearBtn.TabIndex = 13;
            updatebooks_clearBtn.Text = "CLEAR";
            updatebooks_clearBtn.UseVisualStyleBackColor = false;
            updatebooks_clearBtn.Click += updatebooks_clearBtn_Click;
            // 
            // updatebooks_updateBtn
            // 
            updatebooks_updateBtn.BackColor = Color.FromArgb(14, 128, 87);
            updatebooks_updateBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            updatebooks_updateBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            updatebooks_updateBtn.FlatStyle = FlatStyle.Flat;
            updatebooks_updateBtn.Font = new Font("Arial Narrow", 10F);
            updatebooks_updateBtn.ForeColor = Color.White;
            updatebooks_updateBtn.Location = new Point(29, 446);
            updatebooks_updateBtn.Name = "updatebooks_updateBtn";
            updatebooks_updateBtn.Size = new Size(112, 52);
            updatebooks_updateBtn.TabIndex = 12;
            updatebooks_updateBtn.Text = "UPDATE";
            updatebooks_updateBtn.UseVisualStyleBackColor = false;
            updatebooks_updateBtn.Click += updatebooks_updateBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
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
            // 
            // updatebooks_ISBN
            // 
            updatebooks_ISBN.Location = new Point(99, 284);
            updatebooks_ISBN.Name = "updatebooks_ISBN";
            updatebooks_ISBN.Size = new Size(185, 31);
            updatebooks_ISBN.TabIndex = 7;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(updatebooks_branch);
            panel1.Controls.Add(updatebooks_status);
            panel1.Controls.Add(updatebooks_title);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(updatebooks_clearBtn);
            panel1.Controls.Add(updatebooks_updateBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(updatebooks_ISBN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(updatebooks_genre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(updatebooks_author);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(9, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 530);
            panel1.TabIndex = 4;
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
            // updatebooks_genre
            // 
            updatebooks_genre.Location = new Point(99, 244);
            updatebooks_genre.Name = "updatebooks_genre";
            updatebooks_genre.Size = new Size(185, 31);
            updatebooks_genre.TabIndex = 3;
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
            // updatebooks_author
            // 
            updatebooks_author.Location = new Point(99, 200);
            updatebooks_author.Name = "updatebooks_author";
            updatebooks_author.Size = new Size(185, 31);
            updatebooks_author.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(314, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 530);
            panel2.TabIndex = 5;
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
            dataGridView1.Location = new Point(18, 65);
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
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // UpdateBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UpdateBooks";
            Size = new Size(880, 565);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox updatebooks_branch;
        private ComboBox updatebooks_status;
        private TextBox updatebooks_title;
        private Label label8;
        private Button updatebooks_clearBtn;
        private Button updatebooks_updateBtn;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox updatebooks_ISBN;
        private Label label5;
        private Panel panel1;
        private Label label4;
        private TextBox updatebooks_genre;
        private Label label3;
        private TextBox updatebooks_author;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
