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
using Zwembad_Models;

namespace Zwembad_WPF
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

        Zwembad zwembad = new Zwembad();
        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {          
            if (double.TryParse(txtBreedte.Text, out double breedte) && double.TryParse(txtDiepte.Text, out double diepte) && double.TryParse(txtLengte.Text, out double lengte) && double.TryParse(txtRandafstand.Text, out double randafstand))
            {
                zwembad.Breedte = breedte;
                zwembad.Diepte = diepte;
                zwembad.Lengte = lengte;
                zwembad.Randafstand = randafstand;

                txtResultaat.Text = zwembad.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Foutieve waarden", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}