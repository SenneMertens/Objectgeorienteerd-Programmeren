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

        List<Rekening> rekeningen = null;        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FileReader filereader = new FileReader();
            rekeningen = filereader.BestandLezen("rekeningen.txt");

            cmbRekening.ItemsSource = rekeningen;
        }

        private void BtnRekeningToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Rekening rekening = null;

            if (! string.IsNullOrEmpty(txtRekeningNummer.Text))
            {                
                if (rbRekening.IsChecked == true)
                {
                    rekening = new Rekening(txtRekeningNummer.Text, 0);
                }
                else if (rbSpaarrekening.IsChecked == true)
                {
                    rekening = new Spaarrekening();
                    rekening.IbanNummer = txtRekeningNummer.Text;
                }
                else if (rbZichtrekening.IsChecked == true)
                {
                    rekening = new Zichtrekening(txtRekeningNummer.Text, 0);
                }

                if (! rekeningen.Contains(rekening))
                {
                    rekeningen.Add(rekening);

                    cmbRekening.Items.Refresh();
                }
                else
                {
                    MessageBox.Show($"Deze rekening zit al in de lijst: {txtRekeningNummer.Text}.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Geef een correct Iban nummer.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRekeningPlus_Click(object sender, RoutedEventArgs e)
        {
            if (cmbRekening.SelectedItem is Rekening rekening)
            {
                if (double.TryParse(txtRekening.Text, out double bedrag))
                {
                    rekening.Storten(Math.Abs(bedrag));

                    lblToonRekening.Content = rekening.ToString();
                }
                else
                {
                    MessageBox.Show($"Geef een correct bedrag.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Selecteer een rekening.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRekeningMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbRekening.SelectedItem is Rekening rekening)
                {
                    if (double.TryParse(txtRekening.Text, out double bedrag))
                    {
                        rekening.Afhalen(Math.Abs(bedrag));

                        lblToonRekening.Content = rekening.ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Geef een correct bedrag.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Selecteer een rekening.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", $"{ex.GetType().Name}", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRente_Click(object sender, RoutedEventArgs e)
        {
            if (cmbRekening.SelectedItem is Spaarrekening rekening)
            {
                rekening.SchrijfRenteBij(rekening.Percentage);

                lblToonRekening.Content = rekening.ToString();
            }
            else
            {
                MessageBox.Show($"Selecteer een spaarrekening.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CmbRekening_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbRekening.SelectedItem is Rekening rekening)
            {
                lblToonRekening.Content = rekening.ToString();
            }
        }
    }
}