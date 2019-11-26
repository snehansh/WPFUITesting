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

namespace WPFUITesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumberHolder holder = new NumberHolder();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = holder;
        }

        private void IncrementClicked(object sender, RoutedEventArgs e)
        {
            holder.Number++;
        }
    }
}
