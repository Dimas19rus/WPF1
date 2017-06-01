using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public MainWindow WindowBose;
        public Window1(MainWindow w)
        {           
            InitializeComponent();
            WindowBose = w;            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MetodsWindows.SaveFile(WindowBose);            
                Close();
                WindowBose.Close();           
        }

        private void NotSave_Click(object sender, RoutedEventArgs e)
        {
            Close();
            WindowBose.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
