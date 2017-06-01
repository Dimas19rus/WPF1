using System.IO;
using System.Text;
using System.Windows.Controls;
using Microsoft.Win32;

namespace WpfApplication
{
    public abstract class MetodsWindows
    {
        public static void SaveFile(MainWindow window)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            fileDialog.FileName = window.FullNameFileOpen;
            if (File.Exists(fileDialog.FileName))
            {
                using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
                {
                    sw.Write(window.TextBox.Text);
                    sw.Close();
                }
            }
            else
            {
                if (fileDialog.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
                    {
                        sw.Write(window.TextBox.Text);
                        sw.Close();
                    }
                }
                
            }
        }

        public static void SaveAsFile(MainWindow window)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
                {
                    sw.Write(window.TextBox.Text);
                    sw.Close();
                }
            }
        }

        public static void OpenFile(MainWindow window)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Multiselect = false;
            fileDialog.Filter = "Text files (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == true)
            {
                window.FullNameFileOpen = fileDialog.FileName;
                FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                using (StreamReader file = new StreamReader(fileInfo.ToString(), Encoding.Default))
                {
                    window.TextBox.Text = file.ReadToEnd();
                    file.Close();
                }             
            }
        }

        public static bool CheckingTheChangesFile(MainWindow window)
        {
            if (File.Exists(window.FullNameFileOpen))
                using (StreamReader file = new StreamReader(window.FullNameFileOpen, Encoding.Default))
                    if (window.TextBox.Text == file.ReadToEnd())
                    {
                        return false;
                    }
            return true;
        }

    }
}