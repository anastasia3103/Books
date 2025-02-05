using Books.View.Pages;
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

namespace Books
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListViewPage());
        }

        private void ListBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListBoxPage());

        }

        private void DataGridBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DataGridPage());

        }
    }
}
