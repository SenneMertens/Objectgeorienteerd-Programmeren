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

namespace Kassa_WPF
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

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtAantal.Text = $"";
            txtPrijs.Text = $"";
            lblResultaat.Content = $"";
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            float prijs;
            int aantal;
            string resultaat;

            resultaat = string.Empty;

            if (float.TryParse(txtPrijs.Text, out prijs))
            {
                if (int.TryParse(txtAantal.Text, out aantal))
                {
                    resultaat = $"{(prijs * aantal):0.00} €";
                }
            }
            else
            {
                resultaat = $"Ongeldige invoer";
            }

            lblResultaat.Content = resultaat;
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}