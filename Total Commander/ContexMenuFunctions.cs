using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Total_Commander.Properties;

namespace Total_Commander
{
    public partial class Maket : System.Windows.Forms.UserControl
    {
        /* FUNCTIONS IN CONTEX MENU:
            1. CREATE DIRECTORY                   - DONE
            2. DELETE FILE/DIRECTORY              - DONE
            3. RENAME FILE/DIRECTORY              - DONE
            4. COPY FILE/DIRECTORY                - DONE
            5. SHOW FILE/DIRECTORY PROPERTIES     - DONE
            6* ZIP ARCHIVE                        - DONE
        */

        // 1. CREATE FILE
        public void CreateFileOrDirectrory(object sender, EventArgs e)
        {
            if (textBox_search_bar.Text == string.Empty)
            {
                return;
            }

            var btn = sender as ToolStripMenuItem;

            TextBox tbox = new TextBox();
            Controls.Add(tbox);
            tbox.Width = listView1.Columns[1].Width;

            ListViewItem item;
            
            if (btn.Text == "Создать файл")
            {
                item = new ListViewItem(new string[] { "", "Новый файл", "", "", "0 KB" });
            } else
            {
                item = new ListViewItem(new string[] { "", "Новая папка", "", "Системная папка", "" });
            }

            ImageList img = new ImageList();
            //img.Images.Add(Resources.folder_icon);

            //item.ImageIndex = 0;
            listView1.Items.Add(item);

            if (item != null)
            {
                curItem = item.SubItems[1].Text;
                int x_cord = listView1.Columns[0].Width;
                tbox.Left = x_cord;
                tbox.Top = item.Position.Y;
                tbox.Text = item.SubItems[1].Text;
                tbox.Leave += _DisposeTextBox;
                tbox.KeyPress += _TextBoxKeyPress;
                listView1.Controls.Add(tbox);
                tbox.Focus();
                tbox.Select(tbox.Text.Length, 1);
            }
        }

        private void _DisposeTextBox(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            var item = listView1.GetItemAt(0, tb.Top + 1);

            if ((item.SubItems[3].Text == "Системная папка" && tb.Text.Contains(".")) || tb.Text == string.Empty) // Directory name valid
            {
                return;
            }
            else if ((item.SubItems[4].Text == "0 KB" && !tb.Text.Contains(".")) || tb.Text == string.Empty) // File name valid
            {
                return;
            }

            try
            {
                if (item != null)
                {
                    string path = textBox_search_bar.Text + "\\" + tb.Text;

                    if (item.SubItems[3].Text == "Системная папка")
                    {
                        Directory.CreateDirectory(path + "\\");
                    } else
                    {
                        File.Create(path).Close();
                    }

                    LoadFilesAndDirectories(textBox_search_bar.Text);
                }

                tb.Dispose();
                RenewAnotherMaket();
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (sender as TextBox);
            if (e.KeyChar == 13)
            {
                if (tb.Text == string.Empty || SearchItem(tb.Text))
                    MessageBox.Show("Пустое или занятое название!");
                else 
                    _DisposeTextBox((sender as TextBox), null);
            }
            if (e.KeyChar == 27)
            {
                (sender as TextBox).Dispose();
                listView1.Items[listView1.Items.Count - 1].Remove();
            }
        }

        // 2. DELETE FILE
        public void DeleteFilesAndDirectories(object sender, EventArgs e)
        {
            var myThread = new Thread(DeleteThreadFunction);
            myThread.Start(); //метод выполняется в другом потоке
        }

        private void DeleteThreadFunction()
        {
            Action action = DeleteThisFileDir;

            // Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void DeleteThisFileDir()
        {

            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }

            if (MessageBox.Show("Вы точно хотите удалить файл?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                string curItem = listView1.SelectedItems[i].SubItems[1].Text;
                string filepath = Files.Find(f => f.Name == curItem && f.Ext == listView1.SelectedItems[i].SubItems[3].Text).Path;

                if (listView1.SelectedItems[i].SubItems[3].Text == "Системная папка")
                {
                    DirectoryInfo di = new DirectoryInfo(filepath);

                    di.Delete(true);
                    Files.RemoveAt(Files.FindIndex(f => f.Name == curItem));
                }
                else
                {
                    File.Delete(filepath);
                    Files.RemoveAt(Files.FindIndex(f => f.Name == curItem));
                }

            }

            foreach (ListViewItem it in listView1.SelectedItems)
            {
                listView1.Items.Remove(it);
            }

            RenewAnotherMaket();
        }

        // 3. RENAME FILE
        public void RenameFileOrDirectory(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }

            TextBox tbox = new TextBox();
            Controls.Add(tbox);
            tbox.Width = listView1.Columns[1].Width;
            ListViewItem item = listView1.SelectedItems[0];
            if (item != null)
            {
                curItem = item.SubItems[1].Text;
                int x_cord = listView1.Columns[0].Width;
                tbox.Left = x_cord;
                tbox.Top = item.Position.Y;
                tbox.Text = item.SubItems[1].Text;
                tbox.Leave += DisposeTextBox;
                tbox.KeyPress += TextBoxKeyPress;
                listView1.Controls.Add(tbox);
                tbox.Focus();
                tbox.Select(tbox.Text.Length, 1);
            }
        }

        private void DisposeTextBox(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            var item = listView1.GetItemAt(0, tb.Top + 1);
            if (item != null)
                item.SubItems[1].Text = tb.Text;
            tb.Dispose();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                DisposeTextBox((sender as TextBox), null);
                Rename();
                RenewAnotherMaket();
            }
            if (e.KeyChar == 27)
                (sender as TextBox).Dispose();
        }

        // 4 COPY FILES & DIRECTORIES (In )

        public void CopyFilesAndDirectories(object sender, EventArgs e)
        {
            Thread thread = new Thread(CopyThreadFunction);
            thread.Start();
        }

        private void CopyThreadFunction()
        {
            Action action = CopyFileAndDir;

            // Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void CopyFileAndDir()
        {
            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }

            if (WhereToCopy == null || WhereToCopy == string.Empty)
            {
                MessageBox.Show("Пустой путь для копирования файла!");
                return;
            }

            string path = WhereToCopy;

            try
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    string curItem = item.SubItems[1].Text;
                    string filepath = Files.Find(f => f.Name == curItem && f.Ext == item.SubItems[3].Text).Path;


                    if (item.SubItems[3].Text != "Системная папка")
                    {
                        if (!File.Exists(filepath))
                        {
                            MessageBox.Show($"Не найден файл: {curItem}");
                            return;
                        }

                        File.Copy(filepath, WhereToCopy + "\\" + item.SubItems[1].Text + item.SubItems[3].Text);
                    }
                    else
                    {
                        if (!Directory.Exists(filepath + "\\"))
                        {
                            throw new DirectoryNotFoundException($"Source directory not found: {curItem}");
                        }

                        CopyDirectory(filepath, WhereToCopy + "\\" + curItem, true);
                    }
                }
                RenewAnotherMaket();
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\n" + ex.Message);
            }
        }
        private void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        // 5. SHOW FILE PROPERTIES
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }
        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;

        public static bool ShowFileProperties(string Filename)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = Filename;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }

        private void FileDirProperties(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }

            string curItem = listView1.SelectedItems[0].SubItems[1].Text;
            string filepath = Files.Find(f => f.Name == curItem).Path;

            ShowFileProperties(filepath);
        }

        // 6* ZIP-ARCHIVE
        private void FileDirZIP(object sender, EventArgs e)
        {
            Thread thread = new Thread(ZIPThreadFunction);
            thread.Start();
        }

        private void ZIPThreadFunction()
        {
            Action action = CompressAsync;

            // Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }

        private void CompressAsync()
        {
            if (listView1.SelectedItems.Count < 1)
            {
                return;
            }

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string curItem = item.SubItems[1].Text;
                File_ file = Files.Find(f => f.Name == curItem);
                string sourceFileDir = file.Path;
                string compressedFileDir = BackToDirect(sourceFileDir) + curItem + ".zip";

                try
                {
                    if (file.Ext == "Системная папка")
                    {
                        ZipFile.CreateFromDirectory(sourceFileDir, compressedFileDir);
                        MessageBox.Show($"Папка {sourceFileDir} архивирована в файл {compressedFileDir}");
                        
                    }
                    else
                    {
                        // поток для чтения исходного файла
                        using (FileStream sourceStream = new FileStream(sourceFileDir, FileMode.OpenOrCreate))
                        {
                            // поток для записи сжатого файла
                            using (FileStream targetStream = File.Create(compressedFileDir))
                            {
                                using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                                {
                                    // поток архивации
                                    sourceStream.CopyToAsync(compressionStream); // копируем байты из одного потока в другой
                                    MessageBox.Show($"Сжатие файла {sourceFileDir} завершено.");
                                    MessageBox.Show($"Исходный размер: {sourceStream.Length}  сжатый размер: {targetStream.Length}");
                                }
                            }
                        }
                    }


                } catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!" + ex.Message);
                    return;
                }
            }
            LoadFilesAndDirectories(textBox_search_bar.Text);
            RenewAnotherMaket();
        }

    }
}
