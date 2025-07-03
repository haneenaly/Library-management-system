namespace LibraryMS
{
    partial class ReviewBooks
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            addReview_book = new TextBox();
            addReview_booklable = new Label();
            addReview_clearBtn = new Button();
            addReview_addBtn = new Button();
            addReview_review = new RichTextBox();
            addReview_ID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            bookReview_review = new RichTextBox();
            bookReview_book = new TextBox();
            bookReview_name = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 216);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(14, 128, 87);
            dataGridViewCellStyle3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(790, 157);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 1;
            label1.Text = "All Available Books";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(addReview_book);
            panel1.Controls.Add(addReview_booklable);
            panel1.Controls.Add(addReview_clearBtn);
            panel1.Controls.Add(addReview_addBtn);
            panel1.Controls.Add(addReview_review);
            panel1.Controls.Add(addReview_ID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 300);
            panel1.TabIndex = 3;
            // 
            // addReview_book
            // 
            addReview_book.Location = new Point(135, 98);
            addReview_book.Name = "addReview_book";
            addReview_book.Size = new Size(201, 31);
            addReview_book.TabIndex = 31;
            // 
            // addReview_booklable
            // 
            addReview_booklable.AutoSize = true;
            addReview_booklable.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addReview_booklable.Location = new Point(47, 98);
            addReview_booklable.Name = "addReview_booklable";
            addReview_booklable.Size = new Size(73, 29);
            addReview_booklable.TabIndex = 30;
            addReview_booklable.Text = "Book:";
            // 
            // addReview_clearBtn
            // 
            addReview_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            addReview_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addReview_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addReview_clearBtn.FlatStyle = FlatStyle.Flat;
            addReview_clearBtn.Font = new Font("Arial Narrow", 10F);
            addReview_clearBtn.ForeColor = Color.White;
            addReview_clearBtn.Location = new Point(189, 257);
            addReview_clearBtn.Name = "addReview_clearBtn";
            addReview_clearBtn.Size = new Size(131, 33);
            addReview_clearBtn.TabIndex = 29;
            addReview_clearBtn.Text = "CLEAR";
            addReview_clearBtn.UseVisualStyleBackColor = false;
            addReview_clearBtn.Click += addReview_clearBtn_Click;
            // 
            // addReview_addBtn
            // 
            addReview_addBtn.BackColor = Color.FromArgb(14, 128, 87);
            addReview_addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addReview_addBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            addReview_addBtn.FlatStyle = FlatStyle.Flat;
            addReview_addBtn.Font = new Font("Arial Narrow", 10F);
            addReview_addBtn.ForeColor = Color.White;
            addReview_addBtn.Location = new Point(35, 257);
            addReview_addBtn.Name = "addReview_addBtn";
            addReview_addBtn.Size = new Size(126, 33);
            addReview_addBtn.TabIndex = 28;
            addReview_addBtn.Text = "ADD";
            addReview_addBtn.UseVisualStyleBackColor = false;
            addReview_addBtn.Click += addReview_addBtn_Click;
            // 
            // addReview_review
            // 
            addReview_review.Location = new Point(20, 158);
            addReview_review.Name = "addReview_review";
            addReview_review.Size = new Size(316, 93);
            addReview_review.TabIndex = 7;
            addReview_review.Text = "";
            // 
            // addReview_ID
            // 
            addReview_ID.Location = new Point(135, 61);
            addReview_ID.Name = "addReview_ID";
            addReview_ID.Size = new Size(201, 31);
            addReview_ID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 126);
            label5.Name = "label5";
            label5.Size = new Size(107, 29);
            label5.TabIndex = 4;
            label5.Text = "REVIEW:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 60);
            label4.Name = "label4";
            label4.Size = new Size(103, 29);
            label4.TabIndex = 3;
            label4.Text = "Your ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 2;
            label2.Text = "ADD REVIEW";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(bookReview_review);
            panel3.Controls.Add(bookReview_book);
            panel3.Controls.Add(bookReview_name);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(406, 249);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 300);
            panel3.TabIndex = 4;
            // 
            // bookReview_review
            // 
            bookReview_review.Location = new Point(14, 158);
            bookReview_review.Name = "bookReview_review";
            bookReview_review.Size = new Size(405, 132);
            bookReview_review.TabIndex = 8;
            bookReview_review.Text = "";
            // 
            // bookReview_book
            // 
            bookReview_book.Location = new Point(226, 84);
            bookReview_book.Name = "bookReview_book";
            bookReview_book.Size = new Size(193, 31);
            bookReview_book.TabIndex = 7;
            // 
            // bookReview_name
            // 
            bookReview_name.Location = new Point(14, 84);
            bookReview_name.Name = "bookReview_name";
            bookReview_name.Size = new Size(184, 31);
            bookReview_name.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 126);
            label8.Name = "label8";
            label8.Size = new Size(107, 29);
            label8.TabIndex = 5;
            label8.Text = "REVIEW:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(226, 47);
            label7.Name = "label7";
            label7.Size = new Size(73, 29);
            label7.TabIndex = 4;
            label7.Text = "Book:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 47);
            label6.Name = "label6";
            label6.Size = new Size(83, 29);
            label6.TabIndex = 3;
            label6.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 18);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 2;
            label3.Text = "BOOK REVIEW";
            // 
            // ReviewBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ReviewBooks";
            Size = new Size(880, 565);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private RichTextBox addReview_review;
        private TextBox addReview_ID;
        private Label label5;
        private Label label4;
        private TextBox bookReview_book;
        private TextBox bookReview_name;
        private Label label8;
        private Label label7;
        private Label label6;
        private RichTextBox bookReview_review;
        private Button addReview_addBtn;
        private Button addReview_clearBtn;
        private TextBox addReview_book;
        private Label addReview_booklable;
    }
}
