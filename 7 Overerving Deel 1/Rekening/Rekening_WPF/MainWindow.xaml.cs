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
using Rekening_DAL;
using Rekening_Models;

namespace Rekening_WPF
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

        Rekening rekening = new Rekening($"BE82 1796 3107 6768", 2000);
        Spaarrekening spaarrekening = new Spaarrekening();
        Zichtrekening zichtrekening = new Zichtrekening($"BE27 2100 0000 2173", 20);
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            spaarrekening.IbanNummer = $"BE35 3630 8305 1137";
            spaarrekening.Saldo = 2000;
            spaarrekening.Percentage = 5;

            lblToonRekening.Content = rekening.ToonGegevens();
            lblToonSpaarrekening.Content = spaarrekening.ToonGegevens();
            lblToonZichtrekening.Content = zichtrekening.ToonGegevens();
        }

        private void BtnRekeningPlus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtRekening.Text, out double bedrag))
            {
                rekening.Storten(bedrag);

                lblToonRekening.Content = rekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRekeningMin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtRekening.Text, out double bedrag))
            {
                rekening.Afhalen(bedrag);

                lblToonRekening.Content = rekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSpaarrekeningPlus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtSpaarrekening.Text, out double bedrag))
            {
                spaarrekening.Storten(bedrag);

                lblToonSpaarrekening.Content = spaarrekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSpaarrekeningMin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtSpaarrekening.Text, out double bedrag))
            {
                spaarrekening.Afhalen(bedrag);

                lblToonSpaarrekening.Content = spaarrekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnZichtrekeningPlus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtZichtrekening.Text, out double bedrag))
            {
                zichtrekening.Storten(bedrag);

                lblToonZichtrekening.Content = zichtrekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnZichtrekeningMin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtZichtrekening.Text, out double bedrag))
            {
                zichtrekening.Afhalen(bedrag);

                lblToonZichtrekening.Content = zichtrekening.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRente_Click(object sender, RoutedEventArgs e)
        {
            spaarrekening.SchrijfRenteBij(spaarrekening.Percentage);

            lblToonSpaarrekening.Content = spaarrekening.ToonGegevens();
        }
    }
}