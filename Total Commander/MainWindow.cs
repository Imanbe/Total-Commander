using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Total_Commander
{
    public partial class MainWindow : Form
    {
        private Maket CurrentMaket;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toolStripButton_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();

            maket1.MyFont = Settings.Font2;
            maket2.MyFont = Settings.Font1;

            maket1.MyFontColor = Settings.Font_color2;
            maket2.MyFontColor = Settings.Font_color1;

            maket1.MyTextBoxColor = Settings.Default2;
            maket2.MyTextBoxColor = Settings.Default1;

            maket1.MyListBoxColor = Settings.Field2;
            maket2.MyListBoxColor = Settings.Field1;
            
            maket1.Update();
            maket2.Update();

            settings.Close();

        }

        private void toolStripButton_delete_Click(object sender, EventArgs e)
        {
            CurrentMaket.DeleteFilesAndDirectories(CurrentMaket, e);
        }

        private void maket1_Enter(object sender, EventArgs e)
        {
            CurrentMaket = maket1;
            CurrentMaket.WhereToCopy = maket2.textBox_search_bar.Text;
            for (int i = 0; i < maket2.listView1.Items.Count; i++)
            {
                maket2.listView1.Items[i].Selected = false;
            }
        }

        private void maket2_Enter(object sender, EventArgs e)
        {
            CurrentMaket = maket2;
            CurrentMaket.WhereToCopy = maket1.textBox_search_bar.Text;
            for (int i = 0; i < maket1.listView1.Items.Count; i++)
            {
                maket1.listView1.Items[i].Selected = false;
            }
        }

        private void toolStripButton_rename_Click(object sender, EventArgs e)
        {
            CurrentMaket.RenameFileOrDirectory(CurrentMaket, e);
        }

        private void toolStripButton_new_file_Click(object sender, EventArgs e)
        {
            CurrentMaket.CreateFileOrDirectrory(CurrentMaket.создатьФайлToolStripMenuItem, e);
        }

        private void toolStripButton_new_direct_Click(object sender, EventArgs e)
        {
            CurrentMaket.CreateFileOrDirectrory(CurrentMaket.создатьПапкуToolStripMenuItem, e);
        }

        private void toolStripButton_copy_Click(object sender, EventArgs e)
        {
            CurrentMaket.CopyFilesAndDirectories(CurrentMaket, e);
            if (CurrentMaket == maket1)
            {
                maket2.LoadFilesAndDirectories(maket2.textBox_search_bar.Text);
            } else
            {
                maket1.LoadFilesAndDirectories(maket1.textBox_search_bar.Text);
            }
        }

        private void maket2_BackColorChanged(object sender, EventArgs e)
        {
            if (maket2.textBox_search_bar.Text == maket1.textBox_search_bar.Text)
                maket1.LoadFilesAndDirectories(maket1.textBox_search_bar.Text);
        }

        // Событие для захвата действия внутри макета, чтобы обновить данные в другом макете (костыль)
        private void maket1_BackColorChanged(object sender, EventArgs e)
        {
            if (maket1.textBox_search_bar.Text == maket2.textBox_search_bar.Text)
                maket2.LoadFilesAndDirectories(maket2.textBox_search_bar.Text);
        }
    }
}
