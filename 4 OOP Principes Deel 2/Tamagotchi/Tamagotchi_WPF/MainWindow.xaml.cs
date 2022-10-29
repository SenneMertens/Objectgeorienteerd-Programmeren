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
using Tamagotchi_Models;

namespace Tamagotchi_WPF
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

        Tamagotchi tamagotchi = null;

        private void BtnAanmaken_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaam.Text))
            {
                MessageBox.Show($"Voer een correcte naam in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                tamagotchi = new Tamagotchi(txtNaam.Text);
                txtNaamTamagotchi.Text = txtNaam.Text;

                MessageBox.Show($"Tamagotchi {txtNaam.Text} is geboren.", $"Hoera", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnKnuffelen_Click(object sender, RoutedEventArgs e)
        {
            tamagotchi?.LiefKozen();
        }

        private void BtnVoederen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtVoedsel.Text, out int voedsel))
            {
                tamagotchi?.Eten(voedsel);
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnStraffen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtStraffen.Text, out int straf))
            {
                tamagotchi?.Straffen(straf);
            }
            else
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnStatus_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = tamagotchi?.Gevoel();
        }
    }
}