
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {         
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void cajaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultadoTextBlock.Text = cajaTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontWeight = FontWeights.Bold;

        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            resultadoTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Foreground = Brushes.Green;
        }

        
    }
}
