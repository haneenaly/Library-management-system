namespace LibraryMS
{
    partial class IssueBooks
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
            panel1 = new Panel();
            issueBooks_title = new TextBox();
            issueBooks_author = new TextBox();
            issueBooks_clearBtn = new Button();
            issueBooks_issueBtn = new Button();
            label2 = new Label();
            issueBooks_issuedate = new DateTimePicker();
            label6 = new Label();
            issueBooks_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            issueBooks_ID = new TextBox();
            label3 = new Label();
            issueBooks_issueID = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(issueBooks_title);
            panel1.Controls.Add(issueBooks_author);
            panel1.Controls.Add(issueBooks_clearBtn);
            panel1.Controls.Add(issueBooks_issueBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(issueBooks_issuedate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(issueBooks_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(issueBooks_ID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(issueBooks_issueID);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(20, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 220);
            panel1.TabIndex = 0;
            // 
            // issueBooks_title
            // 
            issueBooks_title.Location = new Point(493, 11);
            issueBooks_title.Name = "issueBooks_title";
            issueBooks_title.Size = new Size(185, 31);
            issueBooks_title.TabIndex = 30;
            // 
            // issueBooks_author
            // 
            issueBooks_author.Location = new Point(493, 55);
            issueBooks_author.Name = "issueBooks_author";
            issueBooks_author.Size = new Size(185, 31);
            issueBooks_author.TabIndex = 29;
            // 
            // issueBooks_clearBtn
            // 
            issueBooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            issueBooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issueBooks_clearBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            issueBooks_clearBtn.FlatStyle = FlatStyle.Flat;
            issueBooks_clearBtn.Font = new Font("Arial Narrow", 10F);
            issueBooks_clearBtn.ForeColor = Color.White;
            issueBooks_clearBtn.Location = new Point(200, 145);
            issueBooks_clearBtn.Name = "issueBooks_clearBtn";
            issueBooks_clearBtn.Size = new Size(112, 52);
            issueBooks_clearBtn.TabIndex = 28;
            issueBooks_clearBtn.Text = "CLEAR";
            issueBooks_clearBtn.UseVisualStyleBackColor = false;
            issueBooks_clearBtn.Click += issueBooks_clearBtn_Click;
            // 
            // issueBooks_issueBtn
            // 
            issueBooks_issueBtn.BackColor = Color.FromArgb(14, 128, 87);
            issueBooks_issueBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issueBooks_issueBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            issueBooks_issueBtn.FlatStyle = FlatStyle.Flat;
            issueBooks_issueBtn.Font = new Font("Arial Narrow", 10F);
            issueBooks_issueBtn.ForeColor = Color.White;
            issueBooks_issueBtn.Location = new Point(42, 145);
            issueBooks_issueBtn.Name = "issueBooks_issueBtn";
            issueBooks_issueBtn.Size = new Size(112, 52);
            issueBooks_issueBtn.TabIndex = 27;
            issueBooks_issueBtn.Text = "ISSUE";
            issueBooks_issueBtn.UseVisualStyleBackColor = false;
            issueBooks_issueBtn.Click += issueBooks_issueBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(404, 106);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 25;
            label2.Text = "Issue:";
            // 
            // issueBooks_issuedate
            // 
            issueBooks_issuedate.Location = new Point(474, 101);
            issueBooks_issuedate.Name = "issueBooks_issuedate";
            issueBooks_issuedate.Size = new Size(300, 31);
            issueBooks_issuedate.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(392, 58);
            label6.Name = "label6";
            label6.Size = new Size(76, 24);
            label6.TabIndex = 20;
            label6.Text = "Author:";
            // 
            // issueBooks_name
            // 
            issueBooks_name.Location = new Point(146, 91);
            issueBooks_name.Name = "issueBooks_name";
            issueBooks_name.Size = new Size(185, 31);
            issueBooks_name.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(361, 14);
            label5.Name = "label5";
            label5.Size = new Size(107, 24);
            label5.TabIndex = 18;
            label5.Text = "Book Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 54);
            label4.Name = "label4";
            label4.Size = new Size(38, 24);
            label4.TabIndex = 16;
            label4.Text = "ID:";
            // 
            // issueBooks_ID
            // 
            issueBooks_ID.Location = new Point(146, 54);
            issueBooks_ID.Name = "issueBooks_ID";
            issueBooks_ID.Size = new Size(185, 31);
            issueBooks_ID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 94);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 14;
            label3.Text = "Name:";
            // 
            // issueBooks_issueID
            // 
            issueBooks_issueID.Location = new Point(146, 7);
            issueBooks_issueID.Name = "issueBooks_issueID";
            issueBooks_issueID.Size = new Size(185, 31);
            issueBooks_issueID.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(33, 10);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 12;
            label7.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(20, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 312);
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
            dataGridView1.Location = new Point(33, 40);
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
            dataGridView1.Size = new Size(776, 248);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 8);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 1;
            label1.Text = "All Available Books";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private TextBox issueBooks_name;
        private Label label5;
        private Label label4;
        private TextBox issueBooks_ID;
        private Label label3;
        private TextBox issueBooks_issueID;
        private Label label7;
        private Label label2;
        private DateTimePicker issueBooks_issuedate;
        private Button issueBooks_clearBtn;
        private Button issueBooks_issueBtn;
        private DataGridView dataGridView1;
        private TextBox issueBooks_title;
        private TextBox issueBooks_author;
    }
}
