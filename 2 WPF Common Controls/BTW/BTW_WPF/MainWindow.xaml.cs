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

namespace BTW_WPF
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

        private void Rb0_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rb6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rb12_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rb21_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            double bedrag, btw;

            btw = 0;

            if (double.TryParse(txtBedrag.Text, out bedrag))
            {
                if (rb0.IsChecked == true)
                {
                    btw = 1;
                }
                else if (rb6.IsChecked == true)
                {
                    btw = 1.06;
                }
                else if (rb12.IsChecked == true)
                {
                    btw = 1.12;
                }
                else if (rb21.IsChecked == true)
                {
                    btw = 1.21;
                }

                txtBedragInclBTW.Text = $"{(bedrag * btw):0.00} €";
            }
            else
            {
                MessageBox.Show($"Bedrag moet een correcte numerieke waarde bevatten", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}