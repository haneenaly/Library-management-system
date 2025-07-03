namespace LibraryMS
{
    partial class DeleteBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            deletebook_branch = new ComboBox();
            deletebook_status = new ComboBox();
            deletebook_title = new TextBox();
            label8 = new Label();
            deletebook_clearBtn = new Button();
            deletebook_deleteBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            deletebook_ISBN = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            deletebook_genre = new TextBox();
            label3 = new Label();
            deletebook_author = new TextBox();
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
            // deletebook_branch
            // 
            deletebook_branch.FormattingEnabled = true;
            deletebook_branch.Items.AddRange(new object[] { "Dokki", "Haram", "October", "Maadi", "Korba" });
            deletebook_branch.Location = new Point(99, 379);
            deletebook_branch.Name = "deletebook_branch";
            deletebook_branch.Size = new Size(185, 33);
            deletebook_branch.TabIndex = 19;
            // 
            // deletebook_status
            // 
            deletebook_status.FormattingEnabled = true;
            deletebook_status.Items.AddRange(new object[] { "Available", "Borrowed", "Requested" });
            deletebook_status.Location = new Point(99, 331);
            deletebook_status.Name = "deletebook_status";
            deletebook_status.Size = new Size(185, 33);
            deletebook_status.TabIndex = 18;
            // 
            // deletebook_title
            // 
            deletebook_title.Location = new Point(99, 163);
            deletebook_title.Name = "deletebook_title";
            deletebook_title.Size = new Size(185, 31);
            deletebook_title.TabIndex = 16;
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
            // deletebook_clearBtn
            // 
            deletebook_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            deletebook_clearBtn.Cursor = Cursors.Hand;
            deletebook_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            deletebook_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            deletebook_clearBtn.FlatStyle = FlatStyle.Flat;
            deletebook_clearBtn.Font = new Font("Arial Narrow", 10F);
            deletebook_clearBtn.ForeColor = Color.White;
            deletebook_clearBtn.Location = new Point(161, 446);
            deletebook_clearBtn.Name = "deletebook_clearBtn";
            deletebook_clearBtn.Size = new Size(112, 52);
            deletebook_clearBtn.TabIndex = 13;
            deletebook_clearBtn.Text = "CLEAR";
            deletebook_clearBtn.UseVisualStyleBackColor = false;
            deletebook_clearBtn.Click += button2_Click;
            // 
            // deletebook_deleteBtn
            // 
            deletebook_deleteBtn.BackColor = Color.FromArgb(14, 128, 87);
            deletebook_deleteBtn.Cursor = Cursors.Hand;
            deletebook_deleteBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            deletebook_deleteBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            deletebook_deleteBtn.FlatStyle = FlatStyle.Flat;
            deletebook_deleteBtn.Font = new Font("Arial Narrow", 10F);
            deletebook_deleteBtn.ForeColor = Color.White;
            deletebook_deleteBtn.Location = new Point(29, 446);
            deletebook_deleteBtn.Name = "deletebook_deleteBtn";
            deletebook_deleteBtn.Size = new Size(112, 52);
            deletebook_deleteBtn.TabIndex = 12;
            deletebook_deleteBtn.Text = "DELETE";
            deletebook_deleteBtn.UseVisualStyleBackColor = false;
            deletebook_deleteBtn.Click += button1_Click;
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
            // deletebook_ISBN
            // 
            deletebook_ISBN.Location = new Point(99, 284);
            deletebook_ISBN.Name = "deletebook_ISBN";
            deletebook_ISBN.Size = new Size(185, 31);
            deletebook_ISBN.TabIndex = 7;
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
            panel1.Controls.Add(deletebook_branch);
            panel1.Controls.Add(deletebook_status);
            panel1.Controls.Add(deletebook_title);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(deletebook_clearBtn);
            panel1.Controls.Add(deletebook_deleteBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(deletebook_ISBN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(deletebook_genre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deletebook_author);
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
            // deletebook_genre
            // 
            deletebook_genre.Location = new Point(99, 244);
            deletebook_genre.Name = "deletebook_genre";
            deletebook_genre.Size = new Size(185, 31);
            deletebook_genre.TabIndex = 3;
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
            // deletebook_author
            // 
            deletebook_author.Location = new Point(99, 200);
            deletebook_author.Name = "deletebook_author";
            deletebook_author.Size = new Size(185, 31);
            deletebook_author.TabIndex = 2;
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
            dataGridView1.Location = new Point(19, 83);
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
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // DeleteBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "DeleteBooks";
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

        private ComboBox deletebook_branch;
        private ComboBox deletebook_status;
        private TextBox deletebook_title;
        private Label label8;
        private Button deletebook_clearBtn;
        private Button deletebook_deleteBtn;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox deletebook_ISBN;
        private Label label5;
        private Panel panel1;
        private Label label4;
        private TextBox deletebook_genre;
        private Label label3;
        private TextBox deletebook_author;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
