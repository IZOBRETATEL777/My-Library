namespace My_Library
{
    partial class ShowDataTable
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
            this.Close_button = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.textForSearch = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Eidit_buttoon = new System.Windows.Forms.Button();
            this.Abort_button = new System.Windows.Forms.Button();
            this.Exit_lable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.SaveEdits_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.Red;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Close_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Close_button.Location = new System.Drawing.Point(951, 613);
            this.Close_button.Margin = new System.Windows.Forms.Padding(4);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(162, 58);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "Назад";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToResizeColumns = false;
            this.Data.AllowUserToResizeRows = false;
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(13, 76);
            this.Data.Margin = new System.Windows.Forms.Padding(4);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Size = new System.Drawing.Size(1092, 431);
            this.Data.TabIndex = 1;
            // 
            // textForSearch
            // 
            this.textForSearch.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.textForSearch.Location = new System.Drawing.Point(13, 529);
            this.textForSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textForSearch.Name = "textForSearch";
            this.textForSearch.Size = new System.Drawing.Size(807, 43);
            this.textForSearch.TabIndex = 2;
            this.textForSearch.Click += new System.EventHandler(this.TextForSearch_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.Search_button.FlatAppearance.BorderSize = 0;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Search_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Search_button.Location = new System.Drawing.Point(886, 529);
            this.Search_button.Margin = new System.Windows.Forms.Padding(4);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(162, 56);
            this.Search_button.TabIndex = 3;
            this.Search_button.Text = "Искать";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Eidit_buttoon
            // 
            this.Eidit_buttoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.Eidit_buttoon.FlatAppearance.BorderSize = 0;
            this.Eidit_buttoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eidit_buttoon.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Eidit_buttoon.ForeColor = System.Drawing.SystemColors.Control;
            this.Eidit_buttoon.Location = new System.Drawing.Point(13, 606);
            this.Eidit_buttoon.Margin = new System.Windows.Forms.Padding(4);
            this.Eidit_buttoon.Name = "Eidit_buttoon";
            this.Eidit_buttoon.Size = new System.Drawing.Size(232, 49);
            this.Eidit_buttoon.TabIndex = 4;
            this.Eidit_buttoon.Text = "Редактировать";
            this.Eidit_buttoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eidit_buttoon.UseVisualStyleBackColor = false;
            this.Eidit_buttoon.Click += new System.EventHandler(this.Eidit_buttoon_Click);
            // 
            // Abort_button
            // 
            this.Abort_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.Abort_button.Enabled = false;
            this.Abort_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Abort_button.FlatAppearance.BorderSize = 0;
            this.Abort_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Abort_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abort_button.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.Abort_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Abort_button.Location = new System.Drawing.Point(629, 606);
            this.Abort_button.Margin = new System.Windows.Forms.Padding(4);
            this.Abort_button.Name = "Abort_button";
            this.Abort_button.Size = new System.Drawing.Size(314, 49);
            this.Abort_button.TabIndex = 6;
            this.Abort_button.Text = "Отменить изменения";
            this.Abort_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abort_button.UseVisualStyleBackColor = false;
            this.Abort_button.Click += new System.EventHandler(this.Abort_button_Click);
            // 
            // Exit_lable
            // 
            this.Exit_lable.AutoSize = true;
            this.Exit_lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exit_lable.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.Exit_lable.Location = new System.Drawing.Point(1084, 0);
            this.Exit_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit_lable.Name = "Exit_lable";
            this.Exit_lable.Size = new System.Drawing.Size(29, 35);
            this.Exit_lable.TabIndex = 7;
            this.Exit_lable.Text = "x";
            this.Exit_lable.Click += new System.EventHandler(this.Exit_lable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.Exit_lable);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 444);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowDataTable_MouseDown);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logo.ForeColor = System.Drawing.SystemColors.Control;
            this.Logo.Location = new System.Drawing.Point(348, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(429, 57);
            this.Logo.TabIndex = 8;
            this.Logo.Text = "Моя библиотека";
            // 
            // SaveEdits_button
            // 
            this.SaveEdits_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.SaveEdits_button.Enabled = false;
            this.SaveEdits_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveEdits_button.FlatAppearance.BorderSize = 0;
            this.SaveEdits_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SaveEdits_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEdits_button.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F);
            this.SaveEdits_button.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveEdits_button.Location = new System.Drawing.Point(265, 606);
            this.SaveEdits_button.Name = "SaveEdits_button";
            this.SaveEdits_button.Size = new System.Drawing.Size(341, 49);
            this.SaveEdits_button.TabIndex = 9;
            this.SaveEdits_button.Text = "Сохранить изменения";
            this.SaveEdits_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveEdits_button.UseVisualStyleBackColor = false;
            this.SaveEdits_button.Click += new System.EventHandler(this.SaveEdits_button_Click);
            // 
            // ShowDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1118, 684);
            this.Controls.Add(this.SaveEdits_button);
            this.Controls.Add(this.Abort_button);
            this.Controls.Add(this.Eidit_buttoon);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.textForSearch);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowDataTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDataTable";
            this.Load += new System.EventHandler(this.ShowDataTable_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowDataTable_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.TextBox textForSearch;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Eidit_buttoon;
        private System.Windows.Forms.Button Abort_button;
        private System.Windows.Forms.Label Exit_lable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveEdits_button;
        private System.Windows.Forms.Label Logo;
    }
}