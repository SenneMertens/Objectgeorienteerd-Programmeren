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
using Cilinder_DAL;
using Cilinder_Models;

namespace Cilinder_WPF
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

        Punt punt = null;
        Cirkel cirkel = null;
        Cilinder cilinder = null;

        List<Punt> punten = new List<Punt>();

        private void VoegObjectToe(Punt punt)
        {
            if (! punten.Contains(punt))
            {
                punten.Add(punt);

                lbResultaat.Items.Refresh();
            }
            else
            {
                MessageBox.Show($"{punt.ToString()} zit al in de lijst.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbResultaat.ItemsSource = punten;
            lbResultaat.DisplayMemberPath = "Omschrijving";
        }

        private void BtnPunt_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                punt = new Punt(x, y);

                VoegObjectToe(punt);

                lblResultaat.Content = punt.ToString();
            }
            else
            {
                MessageBox.Show($"Voer geldige waarden in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCirkel_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y) && double.TryParse(txtR.Text, out double r))
            {
                cirkel = new Cirkel(r, x, y);

                VoegObjectToe(cirkel);

                lblResultaat.Content = cirkel.ToString();
            }
            else
            {
                MessageBox.Show($"Voer geldige waarden in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCilinder_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y) && double.TryParse(txtR.Text, out double r) && double.TryParse(txtH.Text, out double h))
            {
                cilinder = new Cilinder(h, r, x, y);

                VoegObjectToe(cilinder);

                lblResultaat.Content = cilinder.ToString();
            }
            else
            {
                MessageBox.Show($"Voer geldige waarden in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTonen_Click(object sender, RoutedEventArgs e)
        {
            if (lbResultaat.SelectedItem is Punt punt)
            {
                MessageBox.Show($"{punt.ToString()}", $"Gegevens", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Selecteer een vorm uit de lijst.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}