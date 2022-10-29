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
using Vierkant_Models;

namespace Vierkant_WPF
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

        Vierkant vierkant;

        private void BtnInitialiseer_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtZijde.Text, out int zijde))
            {
                vierkant = new Vierkant(zijde);
            }
            else
            {
                MessageBox.Show($"Zijde moet een correcte numerieke waarde bevatten.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTeken_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = vierkant.Teken();
        }

        private void BtnDiagonaal_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = vierkant.Diagonaal().ToString();
        }

        private void BtnOmtrek_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = vierkant.Omtrek().ToString();
        }

        private void BtnOppervlakte_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = vierkant.Oppervlakte().ToString();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}