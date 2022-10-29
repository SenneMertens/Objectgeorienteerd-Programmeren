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

        private void BtnPunt_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                punt = new Punt(x, y);

                lblResultaat.Content = punt.ToonGegevens();
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

                lblResultaat.Content = cirkel.ToonGegevens();
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

                lblResultaat.Content = cilinder.ToonGegevens();
            }
            else
            {
                MessageBox.Show($"Voer geldige waarden in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}