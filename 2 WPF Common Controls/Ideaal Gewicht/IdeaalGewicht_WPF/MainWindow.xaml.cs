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

namespace IdeaalGewicht_WPF
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

        private void RbMan_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbVrouw_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            double lengte, polsomtrek;
            string foutmelding;

            foutmelding = string.Empty;

            if (! double.TryParse(txtLengte.Text, out lengte))
            {
                foutmelding = $"Lengte moet een numeriek getal zijn.{Environment.NewLine}";

                if (! double.TryParse(txtPolsomtrek.Text, out polsomtrek) && rbVrouw.IsChecked == true)
                {
                    foutmelding += $"Polsomtrek moet een numeriek getal zijn.";
                }
            }
            else
            {
                if (rbMan.IsChecked == true)
                {
                    txtIdeaalGewicht.Text = $"{((lengte - 100) * 0.9):0.0} KG";
                }
                else if (rbVrouw.IsChecked == true)
                {
                    polsomtrek = double.Parse(txtPolsomtrek.Text);

                    txtIdeaalGewicht.Text = $"{((lengte + 4 * polsomtrek - 100) / 2):0.0} KG";
                }
            }

            if (foutmelding != string.Empty)
            {
                MessageBox.Show(foutmelding, $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}