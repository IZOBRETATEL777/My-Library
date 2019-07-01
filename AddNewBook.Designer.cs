namespace My_Library
{
    partial class AddNewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBook));
            this.BookName = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InLibrary_chkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SeriesName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.BackColor = System.Drawing.SystemColors.Info;
            this.BookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookName.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.BookName.Location = new System.Drawing.Point(333, 42);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(487, 36);
            this.BookName.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.SystemColors.Info;
            this.Author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Author.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Author.Location = new System.Drawing.Point(333, 94);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(487, 36);
            this.Author.TabIndex = 1;
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.SystemColors.Info;
            this.Genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Genre.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Genre.Location = new System.Drawing.Point(333, 145);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(487, 36);
            this.Genre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр";
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.AddBookButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBookButton.Location = new System.Drawing.Point(674, 482);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(153, 49);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Добавить";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(12, 482);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(153, 49);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Назад";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InLibrary_chkbox
            // 
            this.InLibrary_chkbox.AutoSize = true;
            this.InLibrary_chkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.InLibrary_chkbox.FlatAppearance.BorderSize = 0;
            this.InLibrary_chkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InLibrary_chkbox.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.InLibrary_chkbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InLibrary_chkbox.Location = new System.Drawing.Point(648, 300);
            this.InLibrary_chkbox.Name = "InLibrary_chkbox";
            this.InLibrary_chkbox.Size = new System.Drawing.Size(169, 38);
            this.InLibrary_chkbox.TabIndex = 7;
            this.InLibrary_chkbox.Text = "В наличии";
            this.InLibrary_chkbox.UseVisualStyleBackColor = false;
            this.InLibrary_chkbox.CheckedChanged += new System.EventHandler(this.InLibrary_chkbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Серия";
            // 
            // SeriesName
            // 
            this.SeriesName.BackColor = System.Drawing.SystemColors.Info;
            this.SeriesName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeriesName.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.SeriesName.Location = new System.Drawing.Point(333, 194);
            this.SeriesName.Name = "SeriesName";
            this.SeriesName.Size = new System.Drawing.Size(487, 36);
            this.SeriesName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Год";
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.SystemColors.Info;
            this.Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Year.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Year.Location = new System.Drawing.Point(333, 251);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(487, 36);
            this.Year.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.linkLabel1.Location = new System.Drawing.Point(327, 350);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(507, 77);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Основные поля помечены как * и должны быть заполнены";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 572);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.label6.Location = new System.Drawing.Point(798, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // AddNewBook
            // 
            this.AcceptButton = this.AddBookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(834, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SeriesName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InLibrary_chkbox);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1, 817);
            this.Name = "AddNewBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBook";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewBook_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNewBook_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox InLibrary_chkbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SeriesName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}