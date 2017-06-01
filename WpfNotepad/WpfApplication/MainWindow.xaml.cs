using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string FullNameFileOpen;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyphenation_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.TextWrapping = CheckBox.IsChecked.Equals(true) ? TextWrapping.Wrap : TextWrapping.NoWrap;
        }

        private void Spelling_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.SpellCheck.IsEnabled = CheckBox1.IsChecked.Equals(true);
        }

        private void Undo_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Undo();
        }

        private void Redo_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Redo();
        }

        private void Copy_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Copy();
        }

        private void Cut_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Cut();
        }

        private void Pastle_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Paste();
        }

        private void SelectAll_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.SelectAll();
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            MetodsWindows.SaveFile(this);
            //SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.Filter = "Text files (*.txt)|*.txt";
            //fileDialog.FileName = FullNameFileOpen;
            //if (File.Exists(fileDialog.FileName))
            //{
            //    using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
            //    {
            //        sw.Write(TextBox.Text);
            //        sw.Close();
            //    }
            //}
            //else
            //{
            //    if (fileDialog.ShowDialog() == true)
            //    {
            //        using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
            //        {
            //            sw.Write(TextBox.Text);
            //            sw.Close();
            //        }
            //    }
            //}
        }

        private void SaveAs_OnClick(object sender, RoutedEventArgs e)
        {
            MetodsWindows.SaveAsFile(this);
            //SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.Filter = "Text files (*.txt)|*.txt";
            //if (fileDialog.ShowDialog() == true)
            //{
            //    using (StreamWriter sw = new StreamWriter(fileDialog.OpenFile(), System.Text.Encoding.Default))
            //    {
            //        sw.Write(TextBox.Text);
            //        sw.Close();
            //    }
            //}
        }

        private void End_OnClick(object sender, RoutedEventArgs e)
        {
            if (FullNameFileOpen == null)
            {
                if (TextBox.Text != "")
                {
                    Window1 window1 = new Window1(this) { Owner = this };
                    window1.ShowDialog();
                }
                else
                    Close();
            }
            else
            {
                if (MetodsWindows.CheckingTheChangesFile(this))
                {
                    Window1 window1 = new Window1(this) { Owner = this };
                    window1.ShowDialog();
                }
                else
                    Close();
            }
        }

        private void Open_OnClick(object sender, RoutedEventArgs e)
        {
            MetodsWindows.OpenFile(this);
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = false;
            //fileDialog.Filter = "Text files (*.txt)|*.txt";
            //if (fileDialog.ShowDialog() == true)
            //{
            //    FullNameFileOpen = fileDialog.FileName;
            //    FileInfo fileInfo = new FileInfo(fileDialog.FileName);
            //    StreamReader file = new StreamReader(fileInfo.ToString(), Encoding.Default);
            //    TextBox.Text = file.ReadToEnd();

            //    file.Close();
            //}
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            TextBox.Language = XmlLanguage.GetLanguage("ru-Ru");
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            TextBox.Language = XmlLanguage.GetLanguage("en-US");
        }

    }

    
}
