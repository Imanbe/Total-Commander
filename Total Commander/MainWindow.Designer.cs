namespace Total_Commander
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_new_file = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_new_direct = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_rename = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_settings = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.maket2 = new Total_Commander.Maket();
            this.maket1 = new Total_Commander.Maket();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_new_file,
            this.toolStripButton_new_direct,
            this.toolStripButton_delete,
            this.toolStripButton_copy,
            this.toolStripButton_rename,
            this.toolStripButton_settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_new_file
            // 
            this.toolStripButton_new_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_new_file.Image = global::Total_Commander.Properties.Resources.new_file;
            this.toolStripButton_new_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_new_file.Name = "toolStripButton_new_file";
            this.toolStripButton_new_file.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_new_file.Text = "Новый файл";
            this.toolStripButton_new_file.Click += new System.EventHandler(this.toolStripButton_new_file_Click);
            // 
            // toolStripButton_new_direct
            // 
            this.toolStripButton_new_direct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_new_direct.Image = global::Total_Commander.Properties.Resources.new_direct;
            this.toolStripButton_new_direct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_new_direct.Name = "toolStripButton_new_direct";
            this.toolStripButton_new_direct.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_new_direct.Text = "Новая директория";
            this.toolStripButton_new_direct.Click += new System.EventHandler(this.toolStripButton_new_direct_Click);
            // 
            // toolStripButton_delete
            // 
            this.toolStripButton_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_delete.Image = global::Total_Commander.Properties.Resources.delete;
            this.toolStripButton_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_delete.Name = "toolStripButton_delete";
            this.toolStripButton_delete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_delete.Text = "Удалить";
            this.toolStripButton_delete.Click += new System.EventHandler(this.toolStripButton_delete_Click);
            // 
            // toolStripButton_copy
            // 
            this.toolStripButton_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_copy.Image = global::Total_Commander.Properties.Resources.copy;
            this.toolStripButton_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_copy.Name = "toolStripButton_copy";
            this.toolStripButton_copy.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_copy.Text = "Копировать";
            this.toolStripButton_copy.Click += new System.EventHandler(this.toolStripButton_copy_Click);
            // 
            // toolStripButton_rename
            // 
            this.toolStripButton_rename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_rename.Image = global::Total_Commander.Properties.Resources.rename;
            this.toolStripButton_rename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_rename.Name = "toolStripButton_rename";
            this.toolStripButton_rename.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_rename.Text = "Переименовать";
            this.toolStripButton_rename.Click += new System.EventHandler(this.toolStripButton_rename_Click);
            // 
            // toolStripButton_settings
            // 
            this.toolStripButton_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_settings.Image = global::Total_Commander.Properties.Resources.conf;
            this.toolStripButton_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_settings.Name = "toolStripButton_settings";
            this.toolStripButton_settings.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_settings.Text = "Настройки";
            this.toolStripButton_settings.Click += new System.EventHandler(this.toolStripButton_settings_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.maket2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.maket1);
            this.splitContainer1.Size = new System.Drawing.Size(893, 405);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 1;
            // 
            // maket2
            // 
            this.maket2.BackColor = System.Drawing.Color.White;
            this.maket2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maket2.Location = new System.Drawing.Point(0, 0);
            this.maket2.MyDefaultDirectory = null;
            this.maket2.MyFont = null;
            this.maket2.MyFontColor = System.Drawing.Color.Empty;
            this.maket2.MyListBoxColor = System.Drawing.Color.Empty;
            this.maket2.MyTextBoxColor = System.Drawing.Color.Empty;
            this.maket2.Name = "maket2";
            this.maket2.Size = new System.Drawing.Size(465, 405);
            this.maket2.TabIndex = 0;
            this.maket2.WhereToCopy = null;
            this.maket2.BackColorChanged += new System.EventHandler(this.maket2_BackColorChanged);
            this.maket2.Enter += new System.EventHandler(this.maket2_Enter);
            // 
            // maket1
            // 
            this.maket1.BackColor = System.Drawing.Color.White;
            this.maket1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maket1.Location = new System.Drawing.Point(0, 0);
            this.maket1.MyDefaultDirectory = null;
            this.maket1.MyFont = null;
            this.maket1.MyFontColor = System.Drawing.Color.Empty;
            this.maket1.MyListBoxColor = System.Drawing.Color.Empty;
            this.maket1.MyTextBoxColor = System.Drawing.Color.Empty;
            this.maket1.Name = "maket1";
            this.maket1.Size = new System.Drawing.Size(424, 405);
            this.maket1.TabIndex = 0;
            this.maket1.WhereToCopy = null;
            this.maket1.BackColorChanged += new System.EventHandler(this.maket1_BackColorChanged);
            this.maket1.Enter += new System.EventHandler(this.maket1_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 432);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Total Commander";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton_new_file;
        private System.Windows.Forms.ToolStripButton toolStripButton_new_direct;
        private System.Windows.Forms.ToolStripButton toolStripButton_delete;
        private System.Windows.Forms.ToolStripButton toolStripButton_copy;
        private System.Windows.Forms.ToolStripButton toolStripButton_settings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Maket maket2;
        private System.Windows.Forms.ToolStripButton toolStripButton_rename;
        private Maket maket1;
    }
}

