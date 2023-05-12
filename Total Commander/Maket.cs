using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Total_Commander.Properties;
using System.IO.Compression;

namespace Total_Commander
{
    public partial class Maket : UserControl
    {
        private List<File_> Files = new List<File_>();

        private string curItem = string.Empty;

        private Font myFont;
        private Color myFontColor;
        private Color myTextBoxColor;
        private Color myListBoxColor;
        private string myDefaultDriectroy;

        public string WhereToCopy { get; set; }

        public Font MyFont
        {
            get => myFont;
            set
            {
                if (value != null)
                {
                    textBox_search_bar.Font = listView1.Font = myFont = value;
                }
            }
        }

        public Color MyFontColor
        {
            get => myFontColor;
            set
            {
                textBox_search_bar.ForeColor = listView1.ForeColor = myFontColor = value;
            }
        }

        public Color MyTextBoxColor
        {
            get => myTextBoxColor;
            set => textBox_search_bar.BackColor = flowLayoutPanel1.BackColor = myTextBoxColor = value;
        }

        public Color MyListBoxColor
        {
            get => myListBoxColor;
            set
            {
                listView1.BackColor = myListBoxColor = value;
            }
        }

        public string MyDefaultDirectory
        {
            get => myDefaultDriectroy;
            set => dialog.SelectedPath = myDefaultDriectroy = value;
        }

        public Maket()
        {
            InitializeComponent();
            EnableAutoresize(listView1, 1, 5, 3, 4, 2);
        }

        private void Maket_Load(object sender, EventArgs e)
        {
            LoadFilesAndDirectories(Properties.Settings.Default.DefaultPath1);
        }


        /*
        |-------------------------------------|
        |                                     |
        |      EVENTHANDLERS FOR BUTTONS      |
        |                                     |
        |-------------------------------------|
        */

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }

            string curItem = listView1.SelectedItems[0].SubItems[1].Text;

            if (Files.Find(f => f.Name == curItem) == null)
            {
                return;
            }

            string filepath = Files.Find(f => f.Name == curItem).Path;

            try
            {
                if (listView1.SelectedItems[0].SubItems[3].Text == "Системная папка")
                {
                    LoadFilesAndDirectories(filepath);
                    dialog.SelectedPath = textBox_search_bar.Text = filepath;
                }
                else
                {
                    Process.Start(filepath);

                    openFileDialog1.FileName = filepath;
                    openFileDialog1.OpenFile();
                }

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Фйала не существует!\n" + ex.Message);
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_choose_default_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (dialog.SelectedPath != null)
            {
                LoadFilesAndDirectories(dialog.SelectedPath);
            }
        }

        /*
        |-------------------------------------|
        |                                     |
        |            BACK FUNCTIONS           |
        |                                     |
        |-------------------------------------|
        */

        public void LoadFilesAndDirectories(string filepath)
        {
            Files.Clear();
            listView1.Items.Clear();

            Files = Parser.GetFiles(filepath);
            if (Files.Count == 0)
            {
                return;
            }

            var imList = new ImageList();
            
            listView1.LargeImageList = imList;
            listView1.SmallImageList = imList;

            for (int i = 0; i < Files.Count; i++)
            {
                imList.Images.Add(Files[i].Image);

                ListViewItem item = new ListViewItem(new string[] { "", Files[i].Name, Files[i].WriteTime, Files[i].Ext, Files[i].Size })
                {
                    ImageIndex = i
                };

                listView1.Items.Add(item);
            }

            textBox_search_bar.Text = filepath;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (textBox_search_bar.Text == string.Empty)
            {
                return;
            }

            string filespath = BackToDirect(textBox_search_bar.Text);
            
            if (filespath != null)
            {
                textBox_search_bar.Text = dialog.SelectedPath = filespath;
                LoadFilesAndDirectories(filespath);
            }
        }

        private string BackToDirect(string filepath)
        {
            List<string> paths = filepath.Split('\\').Where(f => f != string.Empty).ToList();

            string filespath = null;

            for (int i = 0; i < paths.Count - 1; i++)
            {
                filespath += paths[i] + "\\";
            }

            return filespath;
        }

        private bool SearchItem(string name)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void Rename()
        {
            try
            {
                if (curItem == string.Empty)
                {
                    int i = 1;
                    i++;
                }

                int index = Files.FindIndex(f => f.Name == curItem);
                string filepath = Files[index].Path;
                string WhereRename = BackToDirect(filepath);

                FileInfo fi = new FileInfo(filepath);

                DirectoryInfo dir = new DirectoryInfo(filepath);

                if (fi.Exists)
                {
                    fi.MoveTo(WhereRename + "\\" + listView1.SelectedItems[0].SubItems[1].Text + listView1.SelectedItems[0].SubItems[3].Text);
                }

                if (dir.Exists)
                {
                    dir.MoveTo(WhereRename + "\\" + listView1.SelectedItems[0].SubItems[1].Text);
                }
                curItem = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\n" + ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Enables autoresizing for specific listview.
        /// You can specify how much to scale in columnScaleNumbers array - length of that array
        /// should match column count which you have.
        /// </summary>
        /// <param name="listView">control for which to enable auto-resize</param>
        /// <param name="columnScaleNumbers">Percentage or numbers how much each column will be scaled.</param>
        private void EnableAutoresize(ListView listView, params int[] columnScaleNumbers)
        {
            listView.View = View.Details;
            for (int i = 0; i < columnScaleNumbers.Length; i++)
            {
                if (i >= listView.Columns.Count)
                    break;
                listView.Columns[i].Tag = columnScaleNumbers[i];
            }

            listView.SizeChanged += lvw_SizeChanged;
            DoResize(listView);
        }

        void lvw_SizeChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;
            DoResize(listView);
        }

        bool Resizing = false;
        void DoResize(ListView listView)
        {
            // Don't allow overlapping of SizeChanged calls
            if (!Resizing)
            {
                // Set the resizing flag
                Resizing = true;

                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    // Get the sum of all column tags
                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    // Calculate the percentage of space each column should 
                    // occupy in reference to the other columns and then set the 
                    // width of the column to that percentage of the visible space.
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            // Clear the resizing flag
            Resizing = false;
        }

        private void RenewAnotherMaket()
        {
            // Это действие фиксируется в Form1.cs и запускается событие, которое обновляет файлы и папки в другом макете (костыль)
            BackColor = BackColor == Color.White ? DefaultBackColor : Color.White;
        }
    }
}
