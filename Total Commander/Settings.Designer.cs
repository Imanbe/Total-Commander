namespace Total_Commander
{
    partial class Settings
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox_example1 = new System.Windows.Forms.ListBox();
            this.textBox_example1 = new System.Windows.Forms.TextBox();
            this.listBox_example2 = new System.Windows.Forms.ListBox();
            this.textBox_example2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_field_color1 = new System.Windows.Forms.Button();
            this.button_field_color2 = new System.Windows.Forms.Button();
            this.button_textBox_color1 = new System.Windows.Forms.Button();
            this.button_textBox_color2 = new System.Windows.Forms.Button();
            this.button_textBox_default1 = new System.Windows.Forms.Button();
            this.button_textBox_default2 = new System.Windows.Forms.Button();
            this.button_font1 = new System.Windows.Forms.Button();
            this.button_font2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox_example1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_example1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox_example2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_example2);
            this.splitContainer1.Size = new System.Drawing.Size(682, 221);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 2;
            // 
            // listBox_example1
            // 
            this.listBox_example1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_example1.FormattingEnabled = true;
            this.listBox_example1.ItemHeight = 16;
            this.listBox_example1.Location = new System.Drawing.Point(0, 22);
            this.listBox_example1.Name = "listBox_example1";
            this.listBox_example1.Size = new System.Drawing.Size(337, 199);
            this.listBox_example1.TabIndex = 2;
            // 
            // textBox_example1
            // 
            this.textBox_example1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_example1.Location = new System.Drawing.Point(0, 0);
            this.textBox_example1.Name = "textBox_example1";
            this.textBox_example1.Size = new System.Drawing.Size(337, 22);
            this.textBox_example1.TabIndex = 0;
            // 
            // listBox_example2
            // 
            this.listBox_example2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_example2.FormattingEnabled = true;
            this.listBox_example2.ItemHeight = 16;
            this.listBox_example2.Location = new System.Drawing.Point(0, 22);
            this.listBox_example2.Name = "listBox_example2";
            this.listBox_example2.Size = new System.Drawing.Size(341, 199);
            this.listBox_example2.TabIndex = 1;
            // 
            // textBox_example2
            // 
            this.textBox_example2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_example2.Location = new System.Drawing.Point(0, 0);
            this.textBox_example2.Name = "textBox_example2";
            this.textBox_example2.Size = new System.Drawing.Size(341, 22);
            this.textBox_example2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 221);
            this.panel1.TabIndex = 2;
            // 
            // button_field_color1
            // 
            this.button_field_color1.Location = new System.Drawing.Point(11, 19);
            this.button_field_color1.Name = "button_field_color1";
            this.button_field_color1.Size = new System.Drawing.Size(319, 40);
            this.button_field_color1.TabIndex = 4;
            this.button_field_color1.Text = "Цвет поле файлов";
            this.button_field_color1.UseVisualStyleBackColor = true;
            this.button_field_color1.Click += new System.EventHandler(this.button_field_color1_Click);
            // 
            // button_field_color2
            // 
            this.button_field_color2.Location = new System.Drawing.Point(353, 19);
            this.button_field_color2.Name = "button_field_color2";
            this.button_field_color2.Size = new System.Drawing.Size(319, 40);
            this.button_field_color2.TabIndex = 4;
            this.button_field_color2.Text = "Цвет поле файлов";
            this.button_field_color2.UseVisualStyleBackColor = true;
            this.button_field_color2.Click += new System.EventHandler(this.button_field_color2_Click);
            // 
            // button_textBox_color1
            // 
            this.button_textBox_color1.Location = new System.Drawing.Point(11, 66);
            this.button_textBox_color1.Name = "button_textBox_color1";
            this.button_textBox_color1.Size = new System.Drawing.Size(319, 40);
            this.button_textBox_color1.TabIndex = 4;
            this.button_textBox_color1.Text = "Цвет поисковой строки";
            this.button_textBox_color1.UseVisualStyleBackColor = true;
            this.button_textBox_color1.Click += new System.EventHandler(this.button_textBox_color1_Click);
            // 
            // button_textBox_color2
            // 
            this.button_textBox_color2.Location = new System.Drawing.Point(353, 66);
            this.button_textBox_color2.Name = "button_textBox_color2";
            this.button_textBox_color2.Size = new System.Drawing.Size(319, 40);
            this.button_textBox_color2.TabIndex = 4;
            this.button_textBox_color2.Text = "Цвет поисковой строки";
            this.button_textBox_color2.UseVisualStyleBackColor = true;
            this.button_textBox_color2.Click += new System.EventHandler(this.button_textBox_color2_Click);
            // 
            // button_textBox_default1
            // 
            this.button_textBox_default1.Location = new System.Drawing.Point(11, 160);
            this.button_textBox_default1.Name = "button_textBox_default1";
            this.button_textBox_default1.Size = new System.Drawing.Size(319, 40);
            this.button_textBox_default1.TabIndex = 4;
            this.button_textBox_default1.Text = "Директория по умолчанию";
            this.button_textBox_default1.UseVisualStyleBackColor = true;
            this.button_textBox_default1.Click += new System.EventHandler(this.button_textBox_default1_Click);
            // 
            // button_textBox_default2
            // 
            this.button_textBox_default2.Location = new System.Drawing.Point(353, 160);
            this.button_textBox_default2.Name = "button_textBox_default2";
            this.button_textBox_default2.Size = new System.Drawing.Size(319, 40);
            this.button_textBox_default2.TabIndex = 4;
            this.button_textBox_default2.Text = "Директория по умолчанию";
            this.button_textBox_default2.UseVisualStyleBackColor = true;
            this.button_textBox_default2.Click += new System.EventHandler(this.button_textBox_default2_Click);
            // 
            // button_font1
            // 
            this.button_font1.Location = new System.Drawing.Point(11, 113);
            this.button_font1.Name = "button_font1";
            this.button_font1.Size = new System.Drawing.Size(319, 40);
            this.button_font1.TabIndex = 4;
            this.button_font1.Text = "Шрифт";
            this.button_font1.UseVisualStyleBackColor = true;
            this.button_font1.Click += new System.EventHandler(this.button_font1_Click);
            // 
            // button_font2
            // 
            this.button_font2.Location = new System.Drawing.Point(353, 113);
            this.button_font2.Name = "button_font2";
            this.button_font2.Size = new System.Drawing.Size(319, 40);
            this.button_font2.TabIndex = 4;
            this.button_font2.Text = "Шрифт";
            this.button_font2.UseVisualStyleBackColor = true;
            this.button_font2.Click += new System.EventHandler(this.button_font2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.button_field_color2);
            this.Controls.Add(this.button_textBox_color2);
            this.Controls.Add(this.button_textBox_color1);
            this.Controls.Add(this.button_textBox_default2);
            this.Controls.Add(this.button_textBox_default1);
            this.Controls.Add(this.button_font2);
            this.Controls.Add(this.button_font1);
            this.Controls.Add(this.button_field_color1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Settings";
            this.Text = "Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_example1;
        private System.Windows.Forms.TextBox textBox_example2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_field_color1;
        private System.Windows.Forms.Button button_field_color2;
        private System.Windows.Forms.Button button_textBox_color1;
        private System.Windows.Forms.Button button_textBox_color2;
        private System.Windows.Forms.Button button_textBox_default1;
        private System.Windows.Forms.Button button_textBox_default2;
        private System.Windows.Forms.Button button_font1;
        private System.Windows.Forms.Button button_font2;
        private System.Windows.Forms.ListBox listBox_example1;
        private System.Windows.Forms.ListBox listBox_example2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}