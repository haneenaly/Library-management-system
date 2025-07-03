namespace LibraryMS
{
    partial class RequestBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestBooks));
            requestBooks_title = new TextBox();
            label8 = new Label();
            requestBooks_clearBtn = new Button();
            requestBooks_requestBtn = new Button();
            requestBooks_pic = new PictureBox();
            requestBooks_ISBN = new TextBox();
            label5 = new Label();
            label4 = new Label();
            requestBooks_genre = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            requestBooks_author = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)requestBooks_pic).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // requestBooks_title
            // 
            requestBooks_title.Location = new Point(99, 163);
            requestBooks_title.Name = "requestBooks_title";
            requestBooks_title.Size = new Size(185, 31);
            requestBooks_title.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 235);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 17;
            label8.Text = "Author:";
            // 
            // requestBooks_clearBtn
            // 
            requestBooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            requestBooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            requestBooks_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            requestBooks_clearBtn.FlatStyle = FlatStyle.Flat;
            requestBooks_clearBtn.Font = new Font("Arial Narrow", 10F);
            requestBooks_clearBtn.ForeColor = Color.White;
            requestBooks_clearBtn.Location = new Point(161, 446);
            requestBooks_clearBtn.Name = "requestBooks_clearBtn";
            requestBooks_clearBtn.Size = new Size(112, 52);
            requestBooks_clearBtn.TabIndex = 13;
            requestBooks_clearBtn.Text = "CLEAR";
            requestBooks_clearBtn.UseVisualStyleBackColor = false;
            // 
            // requestBooks_requestBtn
            // 
            requestBooks_requestBtn.BackColor = Color.FromArgb(14, 128, 87);
            requestBooks_requestBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            requestBooks_requestBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            requestBooks_requestBtn.FlatStyle = FlatStyle.Flat;
            requestBooks_requestBtn.Font = new Font("Arial Narrow", 10F);
            requestBooks_requestBtn.ForeColor = Color.White;
            requestBooks_requestBtn.Location = new Point(29, 446);
            requestBooks_requestBtn.Name = "requestBooks_requestBtn";
            requestBooks_requestBtn.Size = new Size(112, 52);
            requestBooks_requestBtn.TabIndex = 12;
            requestBooks_requestBtn.Text = "REQUEST";
            requestBooks_requestBtn.UseVisualStyleBackColor = false;
            requestBooks_requestBtn.Click += requestBooks_requestBtn_Click;
            // 
            // requestBooks_pic
            // 
            requestBooks_pic.BackColor = SystemColors.ButtonHighlight;
            requestBooks_pic.Image = (Image)resources.GetObject("requestBooks_pic.Image");
            requestBooks_pic.Location = new Point(73, 13);
            requestBooks_pic.Name = "requestBooks_pic";
            requestBooks_pic.Size = new Size(117, 113);
            requestBooks_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            requestBooks_pic.TabIndex = 11;
            requestBooks_pic.TabStop = false;
            // 
            // requestBooks_ISBN
            // 
            requestBooks_ISBN.Location = new Point(99, 350);
            requestBooks_ISBN.Name = "requestBooks_ISBN";
            requestBooks_ISBN.Size = new Size(185, 31);
            requestBooks_ISBN.TabIndex = 7;
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
            label4.Location = new Point(18, 296);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 6;
            label4.Text = "Genre:";
            // 
            // requestBooks_genre
            // 
            requestBooks_genre.Location = new Point(99, 293);
            requestBooks_genre.Name = "requestBooks_genre";
            requestBooks_genre.Size = new Size(185, 31);
            requestBooks_genre.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(requestBooks_title);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(requestBooks_clearBtn);
            panel1.Controls.Add(requestBooks_requestBtn);
            panel1.Controls.Add(requestBooks_pic);
            panel1.Controls.Add(requestBooks_ISBN);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(requestBooks_genre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(requestBooks_author);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(9, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 530);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 357);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 4;
            label3.Text = "ISBN:";
            // 
            // requestBooks_author
            // 
            requestBooks_author.Location = new Point(99, 232);
            requestBooks_author.Name = "requestBooks_author";
            requestBooks_author.Size = new Size(185, 31);
            requestBooks_author.TabIndex = 2;
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 79);
            dataGridView1.Name = "dataGridView1";
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
            label1.Size = new Size(245, 34);
            label1.TabIndex = 0;
            label1.Text = "All Available Books";
            // 
            // RequestBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "RequestBooks";
            Size = new Size(880, 565);
            ((System.ComponentModel.ISupportInitialize)requestBooks_pic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox requestBooks_title;
        private Label label8;
        private Button requestBooks_clearBtn;
        private Button requestBooks_requestBtn;
        private PictureBox requestBooks_pic;
        private TextBox requestBooks_ISBN;
        private Label label5;
        private Label label4;
        private TextBox requestBooks_genre;
        private Panel panel1;
        private Label label3;
        private TextBox requestBooks_author;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
