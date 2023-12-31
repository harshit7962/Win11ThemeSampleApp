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

        private void clearAllGroup1(object sender, RoutedEventArgs e)
        {
            checkBox1.IsChecked = checkBox2.IsChecked = checkBox3.IsChecked = false;
        }

        private void checkAllGroup1(object sender, RoutedEventArgs e)
        {
            checkBox1.IsChecked = checkBox2.IsChecked = checkBox3.IsChecked = true;
        }

        private void clearAllGroup2(object sender, RoutedEventArgs e)
        {
            checkBox4.IsChecked = checkBox5.IsChecked = checkBox6.IsChecked = checkBox7.IsChecked = false;
        }

        private void checkAllGroup2(object sender, RoutedEventArgs e)
        {
            checkBox4.IsChecked = checkBox5.IsChecked = checkBox6.IsChecked = checkBox7.IsChecked = true;
        }
    }
}