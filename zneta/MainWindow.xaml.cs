using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication7
{
    /// <summary>
    /// MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isFirstRun;

        public MainWindow()
        {
            isFirstRun = true;

            InitializeComponent();

            isFirstRun = false;
        }

        private void Odp_A_checked(object sender, RoutedEventArgs e)
        {
            if (isFirstRun)
                return;
            App.Background = new SolidColorBrush(Colors.Red);
        }

        private void Odp_B_Checked(object sender, RoutedEventArgs e)
        {
            App.Background = new SolidColorBrush(Colors.Red);
        }
        private void Odp_C_Checked(object sender, RoutedEventArgs e)
        {
            App.Background = new SolidColorBrush(Colors.Green);
        }

        private void Sprawdz(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
