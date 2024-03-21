using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Persons = [
                new Person { Name = "John", Age = 42 },
                new Person { Name = "Lucy", Age = 39 },
                new Person { Name = "Amanda", Age = 29 }
            ];
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException("AAA",
                new Exception("BBB")
                );
        }
    }
}