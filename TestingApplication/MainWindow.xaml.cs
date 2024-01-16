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
        private int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            // Increase the counter and update the TextBlock
            counter++;
            counterText.Text = counter.ToString();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            // ToggleButton is checked
            toggleStateText.Text = "Toggle Switch is ON";
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            // ToggleButton is unchecked
            toggleStateText.Text = "Toggle Switch is OFF";
        }
    }
}