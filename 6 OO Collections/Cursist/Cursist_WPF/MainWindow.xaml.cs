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
using Cursist_DAL;
using Cursist_Models;

namespace Cursist_WPF
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

        List<Cursist> cursisten = new List<Cursist>();

        FileReader filereader = new FileReader();
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cursisten = filereader.LeesBestand("cursisten.txt");

            lbResultaat.ItemsSource = cursisten;
            lbResultaat.DisplayMemberPath = $"Naam";
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (! string.IsNullOrEmpty(txtVoornaam.Text) && ! string.IsNullOrEmpty(txtFamilienaam.Text))
            {
                Cursist cursist = new Cursist(txtVoornaam.Text, txtFamilienaam.Text);

                if (! cursisten.Contains(cursist))
                {
                    cursisten.Add(cursist);

                    lbResultaat.Items.Refresh();
                }
                else
                {
                    MessageBox.Show($"{cursist.Naam} zit al in de lijst.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Geef een correcte naam in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (lbResultaat.SelectedItem is Cursist cursist)
            {
                if (MessageBox.Show($"Wil je {cursist.Naam} verwijderen?", $"Bevestiging", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    cursisten.Remove(cursist);

                    lbResultaat.Items.Refresh();
                } 
            }
            else
            {
                MessageBox.Show($"Maak een correcte selectie", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (lbResultaat.SelectedItem is Cursist cursist)
            {
                if (! string.IsNullOrEmpty(txtVoornaam.Text) && ! string.IsNullOrEmpty(txtFamilienaam.Text))
                {
                    cursist.Voornaam = txtVoornaam.Text;
                    cursist.Familienaam = txtFamilienaam.Text;

                    lbResultaat.Items.Refresh();
                }
                else
                {
                    MessageBox.Show($"Geef een correcte naam in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Maak een correcte selectie", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void LbResultaat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbResultaat.SelectedItem is Cursist cursist)
            {
                txtVoornaam.Text = cursist.Voornaam;
                txtFamilienaam.Text = cursist.Familienaam;
            }
        }
    }
}