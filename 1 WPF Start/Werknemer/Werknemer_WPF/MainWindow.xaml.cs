using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Werknemer_WPF
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

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding;
            float verdiensten;

            foutmelding = string.Empty;

            if (string.IsNullOrEmpty(txtVoornaam.Text))
            {
                foutmelding += $"Voer een correcte voornaam in.";
            }
            if (string.IsNullOrEmpty(txtAchternaam.Text))
            {
                foutmelding += $"\nVoer een correcte achternaam in.";
            }
            if (! float.TryParse(txtVerdiensten.Text, out verdiensten))
            {
                foutmelding += $"\nVoer een correct numeriek bedrag in.";
            }
            if (foutmelding != string.Empty)
            {
                MessageBox.Show(foutmelding, $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                txtResultaat.Text += $"{txtVoornaam.Text.PadRight(30)} {txtAchternaam.Text.PadRight(30)} {verdiensten.ToString("0.00").PadLeft(15)} €\n";
            }
        }
    }
}