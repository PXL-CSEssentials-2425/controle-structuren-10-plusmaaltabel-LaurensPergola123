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

namespace PlusMaalTabel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int MaxValue;
        StringBuilder result = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            

            bool isGeldigGetal = int.TryParse(maximumValueTextBox.Text, out MaxValue);

            if (!isGeldigGetal || MaxValue > 20 || MaxValue < 1) 
            {
                resultTextBox.Clear();
                maximumValueTextBox.Clear();
                maximumValueTextBox.Focus();

                return;
            }

            

            result.Append("\t");

            for (int i = 1; i <= MaxValue; i++)
            {
                result.Append($"{i}\t");
            }
            result.AppendLine().AppendLine();

            for (int i = 1; i <= MaxValue; i++) 
            {
                result.Append($"{i}\t");

                for (int j = 1; j <= MaxValue; j++)
                {
                    result.Append($"{i} + {j}\t");
                }
                result.AppendLine();
            }

            resultTextBox.Text = result.ToString();
        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            maximumValueTextBox.Clear();
            maximumValueTextBox.Focus();    
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            result.Append("\t");

            for (int i = 1; i <= MaxValue; i++)
            {
                result.Append($"{i}\t");
            }
            result.AppendLine().AppendLine();

            for (int i = 1; i <= MaxValue; i++)
            {
                result.Append($"{i}\t");

                for (int j = 1; j <= MaxValue; j++)
                {
                    result.Append($"{i} * {j}\t");
                }
                result.AppendLine();
            }

            resultTextBox.Text = result.ToString();
        }
    }
}