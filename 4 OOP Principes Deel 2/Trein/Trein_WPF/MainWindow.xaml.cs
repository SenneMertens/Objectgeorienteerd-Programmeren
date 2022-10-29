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
using Trein_Models;

namespace Trein_WPF
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

        Trein trein = new Trein();

        public void UpdateResultaat()
        {
            lblResultaat.Content = trein.StandVanZaken();
        }

        private void BtnOpstappen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtOpstappen.Text, out int passagiers))
            {
                if (trein.Opstappen(passagiers))
                {
                    UpdateResultaat();
                }
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAfstappen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtAfstappen.Text, out int passagiers))
            {
                if (trein.Afstappen(passagiers))
                {
                    UpdateResultaat();
                }
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnVersnellen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtVersnellen.Text, out int snelheid))
            {
                if (trein.Versnellen(snelheid))
                {
                    UpdateResultaat();
                }
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnVertragen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtVertragen.Text, out int snelheid))
            {
                trein.Remmen(snelheid);
                UpdateResultaat();
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnStoppen_Click(object sender, RoutedEventArgs e)
        {
            trein.Stoppen();
            UpdateResultaat();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            trein.SluitDeur();
            UpdateResultaat();
        }
    }
}