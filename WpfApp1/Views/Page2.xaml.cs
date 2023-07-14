using Microsoft.Win32;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.Models.Depo;

namespace WpfApp1.Views
{
    public partial class Page2 : Page
    {
        public List<string> Depo { get; set; } = DepoList;
        public Page2()
        {
            InitializeComponent();
            DataContext = this;
        }
        

        

    }
}
