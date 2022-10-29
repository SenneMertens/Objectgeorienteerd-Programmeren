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
using Teller_Models;

namespace Teller_WPF
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

        Teller teller = new Teller();

        private void BtnWeergeven_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(teller.ToonGegevens(), $"Waarde Teller", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVerhogen_Click(object sender, RoutedEventArgs e)
        {
            teller.Verhoog();
        }

        private void BtnVerlagen_Click(object sender, RoutedEventArgs e)
        {
            teller.Verlaag();
        }

        private void BtnResetten_Click(object sender, RoutedEventArgs e)
        {
            teller.Resetten();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}