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

namespace ExPractics01
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

        private void CheckClick(object sender, RoutedEventArgs e)
        {
            boto1.Content = "Noches";
        }
        private void CheckUnclick(object sender, RoutedEventArgs e)
        {
            boto1.Content = "Buenas";
        }

        private void botton2(object sender, RoutedEventArgs e)
        {
            int numeros;
            if (int.TryParse(Contador.Content.ToString(), out numeros)) {
                if (check.IsChecked == true)
                {
                    numeros += 1;
                    Contador.Content = numeros;
                }
            }
                
        }

    }
}