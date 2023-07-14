using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Views;

namespace WpfApp1
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void addImageButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page1();
        }
        private void galeryButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page2();
        }
    }
}
