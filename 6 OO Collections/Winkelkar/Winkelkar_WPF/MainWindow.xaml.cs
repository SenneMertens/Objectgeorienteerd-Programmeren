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
using Winkelkar_DAL;
using Winkelkar_Models;

namespace Winkelkar_WPF
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

        List<WinkelkarItem> winkelkar = new List<WinkelkarItem>();

        private void BtnTonen_Click(object sender, RoutedEventArgs e)
        {
            lblResultaat.Content = $"";

            foreach (WinkelkarItem item in winkelkar)
            {
                lblResultaat.Content += item.ToString();
            }
            
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtAantal.Text, out int aantal) && double.TryParse(txtPrijs.Text, out double prijs) && !string.IsNullOrEmpty(txtOmschrijving.Text))
            {
                WinkelkarItem item = new WinkelkarItem(aantal, prijs, txtOmschrijving.Text);

                winkelkar.Add(item);
            }
            else
            {
                MessageBox.Show($"Vul alle waarden correct in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}