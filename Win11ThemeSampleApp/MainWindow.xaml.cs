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

namespace Win11ThemeSampleApp
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
        private void OpenPopup_Click(object sender, RoutedEventArgs e)
        {
            // Open the popup
            myPopup.IsOpen = true;
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }
    }
}