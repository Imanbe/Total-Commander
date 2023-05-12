using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Total_Commander.Properties;

namespace Total_Commander
{
    internal static class Parser
    {
        internal static List<File_> GetFiles(string file_path)
        {
            List<File_> files = new List<File_>();
            try
            {

                DirectoryInfo dinfo = new DirectoryInfo(file_path);

                DirectoryInfo[] AllDirectories = dinfo.GetDirectories();

                FileInfo[] AllFiles = dinfo.GetFiles();



                foreach (var fi in AllDirectories)
                {
                    string name = fi.Name;

                    Image img = Resources.folder_icon;

                    DirectoryInfo directoryInfo = new DirectoryInfo(fi.FullName);

                    files.Add(new File_(name, fi.FullName, "Системная папка",img, fi.LastWriteTimeUtc.ToString(), ""));
                }

                foreach (var fi in AllFiles)
                {
                    string name = Path.GetFileNameWithoutExtension(fi.FullName);

                    var ic = Icon.ExtractAssociatedIcon(fi.FullName);
                    ImageList imageList = new ImageList();
                    imageList.Images.Add(".jpeg", ic);
                    Image img = imageList.Images[0];

                    FileInfo fileInfo = new FileInfo(fi.FullName);

                    files.Add(new File_(name, fi.FullName, fi.Extension, img, fi.LastWriteTimeUtc.ToString(), Math.Round(fileInfo.Length / 1024.0, 2).ToString() + " KB"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
            
            return files;
        }
    }
}
