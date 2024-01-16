using System.Diagnostics.Metrics;
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

namespace TestingApplication
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

        private void ShowView1_Click(object sender, RoutedEventArgs e)
        {
            // Set View 1 as the content of the ContentControl
            contentControl.Content = new View1();
        }

        private void ShowView2_Click(object sender, RoutedEventArgs e)
        {
            // Set View 2 as the content of the ContentControl
            contentControl.Content = new View2();
        }
    }
}