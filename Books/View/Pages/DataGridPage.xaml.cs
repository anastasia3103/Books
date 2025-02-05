using Books.Model;
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

namespace Books.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataGridPage.xaml
    /// </summary>
    public partial class DataGridPage : Page
    {
        BookService _bookService;
        public DataGridPage()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BooksDg.ItemsSource = await _bookService.LoadBooksAsync();
        }
    }
}
