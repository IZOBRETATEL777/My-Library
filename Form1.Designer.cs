namespace My_Library
{
    partial class StartPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.OtherStuff_Button = new System.Windows.Forms.Button();
            this.OtherStuff_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDataTable_button = new System.Windows.Forms.Button();
            this.AddBook_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OtherStuff_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Exit_button, "Exit_button");
            this.Exit_button.FlatAppearance.BorderSize = 0;
            this.Exit_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // OtherStuff_Button
            // 
            resources.ApplyResources(this.OtherStuff_Button, "OtherStuff_Button");
            this.OtherStuff_Button.FlatAppearance.BorderSize = 0;
            this.OtherStuff_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.OtherStuff_Button.Name = "OtherStuff_Button";
            this.OtherStuff_Button.UseVisualStyleBackColor = true;
            this.OtherStuff_Button.Click += new System.EventHandler(this.OtherStuff_Button_Click);
            // 
            // OtherStuff_menu
            // 
            this.OtherStuff_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.OtherStuff_menu, "OtherStuff_menu");
            this.OtherStuff_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.отчиститьБазуДанныхToolStripMenuItem,
            this.toolStripMenuItem2,
            this.оПрограммеToolStripMenuItem});
            this.OtherStuff_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.OtherStuff_menu.Name = "OtherStuff_menu";
            this.OtherStuff_menu.ShowImageMargin = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // отчиститьБазуДанныхToolStripMenuItem
            // 
            this.отчиститьБазуДанныхToolStripMenuItem.Name = "отчиститьБазуДанныхToolStripMenuItem";
            resources.ApplyResources(this.отчиститьБазуДанныхToolStripMenuItem, "отчиститьБазуДанныхToolStripMenuItem");
            this.отчиститьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.ОтчиститьБазуДанныхToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // ShowDataTable_button
            // 
            resources.ApplyResources(this.ShowDataTable_button, "ShowDataTable_button");
            this.ShowDataTable_button.FlatAppearance.BorderSize = 0;
            this.ShowDataTable_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.ShowDataTable_button.Name = "ShowDataTable_button";
            this.ShowDataTable_button.UseVisualStyleBackColor = true;
            this.ShowDataTable_button.Click += new System.EventHandler(this.ShowDataTable_button_Click);
            // 
            // AddBook_button
            // 
            resources.ApplyResources(this.AddBook_button, "AddBook_button");
            this.AddBook_button.FlatAppearance.BorderSize = 0;
            this.AddBook_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.AddBook_button.Name = "AddBook_button";
            this.AddBook_button.UseVisualStyleBackColor = true;
            this.AddBook_button.Click += new System.EventHandler(this.AddBook_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // StartPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddBook_button);
            this.Controls.Add(this.ShowDataTable_button);
            this.Controls.Add(this.OtherStuff_Button);
            this.Controls.Add(this.Exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartPage";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.BeSafe);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPage_MouseDown);
            this.OtherStuff_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button OtherStuff_Button;
        private System.Windows.Forms.ContextMenuStrip OtherStuff_menu;
        private System.Windows.Forms.ToolStripMenuItem отчиститьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button ShowDataTable_button;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button AddBook_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

