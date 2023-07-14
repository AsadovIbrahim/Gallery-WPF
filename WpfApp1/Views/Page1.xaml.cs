using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp1.Views
{
    public partial class Page1 : Page, INotifyPropertyChanged
    {

        private string _path;
        public string path
        {
            get => _path;
            set
            {
                _path = value;
                Onp();
            }
        }
        public Page1()
        {
            InitializeComponent();
            DataContext = this;
        }
        private ObservableCollection<string> selectedImagePaths = new ObservableCollection<string>();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void Onp([CallerMemberName] string? name = null) {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == true)
            {
                path = openFileDialog.FileName;
                selectedImagePaths.Add(path);
            }
        }
    }
}
