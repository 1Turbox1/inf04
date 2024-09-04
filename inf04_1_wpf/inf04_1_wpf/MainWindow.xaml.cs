using System.IO;
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

namespace inf04_1_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            string userNumber = "766767";
            this.Title = $"Wprowadzenie danych do paszportu. Wykonał: {userNumber}";
        }

        private void textBoxNumer_LostFocus(object sender, RoutedEventArgs e)
        {
            string numer = textBoxNumer.Text;
            string zdjeciePath = $"C:\\Users\\Tomek\\source\\repos\\inf04_1_wpf\\inf04_1_wpf\\imgs\\{numer}-zdjecie.jpg";
            string odciskPath = $"C:\\Users\\Tomek\\source\\repos\\inf04_1_wpf\\inf04_1_wpf\\imgs\\{numer}-odcisk.jpg";

            if (File.Exists(zdjeciePath))
            {
                pictureBoxZdjecie.Source = new BitmapImage(new Uri(zdjeciePath));
            }
            else
            {
                pictureBoxZdjecie.Source = null;
            }

            if (File.Exists(odciskPath))
            {
                pictureBoxOdcisk.Source = new BitmapImage(new Uri(odciskPath));
            }
            else
            {
                pictureBoxOdcisk.Source = null;
            }
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;

            if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko))
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }

            string kolorOczu = radioButtonNiebieskie.IsChecked == true ? "niebieskie" :
                                radioButtonZielone.IsChecked == true ? "zielone" : "piwne";

            MessageBox.Show($"{imie} {nazwisko} kolor oczu {kolorOczu}");
        }
    }
}