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
using Klant_DAL;
using Klant_Models;

namespace Klant_WPF
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

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(txtKlantnummer.Text, out int nummer))
                {
                    FileOperations fileOperations = new FileOperations();
                    lblResultaat.Content = fileOperations.ZoekKlantViaNummer(nummer).ToString();

                }
                else
                {
                    lblResultaat.Content = "Geef een numerieke klantnummer in!";
                }

            }
            catch (Exception ex)
            {
                lblResultaat.Content = ex.Message;
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}