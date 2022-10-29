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
using Dieren_DAL;
using Dieren_Models;

namespace Dieren_WPF
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

        string mijnDier = $"";
        Dier dier = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> zinnen = new List<string>();

            zinnen.Add($"Goedemorgen");
            zinnen.Add($"Goedemiddag");
            zinnen.Add($"Goedenavond");

            lbZinnen.ItemsSource = zinnen;
        }

        private void BtnDierAanmaken_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDierNaam.Text))
            {
                MessageBox.Show($"Geef je dier een naam.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (rbKat.IsChecked == true)
                {
                    dier = new Kat(txtDierNaam.Text);
                    mijnDier = $"Kat";
                }
                else if (rbMens.IsChecked == true)
                {
                    dier = new Mens(txtDierNaam.Text);
                    mijnDier = $"Mens";
                }
                else
                {
                    dier = new Papegaai(txtDierNaam.Text);
                    mijnDier = $"Papegaai";
                }
            }
        }

        private void BtnPraten_Click(object sender, RoutedEventArgs e)
        {
            if (lbZinnen.SelectedItem is string zin && dier != null)
            {
                MessageBox.Show(dier.Praten(zin), $"Praten", MessageBoxButton.OK, MessageBoxImage.None);
            }
        }

        private void BtnEten_Click(object sender, RoutedEventArgs e)
        {
            if (dier != null)
            {
                if (mijnDier == $"Mens")
                {
                    MessageBox.Show(dier.Eten(), $"Praten", MessageBoxButton.OK, MessageBoxImage.None);
                }
            }           
        }

        private void BtnStrelen_Click(object sender, RoutedEventArgs e)
        {
            if (dier != null)
            {
                MessageBox.Show(dier.Strelen(), $"Praten", MessageBoxButton.OK, MessageBoxImage.None);
            }            
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}