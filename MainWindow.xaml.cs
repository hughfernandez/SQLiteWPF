using SQLiteWPF.Model;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace SQLiteWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var context = new EmployeeContext();
            context.Employees.OrderBy(x => x.FirstName).Load();
            this.dataEmployees.ItemsSource = context.Employees.Local;
        }
    }
}
