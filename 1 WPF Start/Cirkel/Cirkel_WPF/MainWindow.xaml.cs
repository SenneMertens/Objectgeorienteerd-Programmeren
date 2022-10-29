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

namespace Cirkel_WPF
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

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            float straal, omtrek, oppervlakte;
            string resultaat;

            if (float.TryParse(txtStraal.Text, out straal))
            {
                omtrek = (float)(straal * 2 * Math.PI);
                oppervlakte = (float)(Math.Pow(straal, 2) * Math.PI);

                resultaat = $"Omtrek: {omtrek:0.00}\nOppervlakte: {oppervlakte:0.00}";

                lblResultaat.Content = resultaat;
            }
            else
            {
                resultaat = $"Voer een correct getal in";
                
                MessageBox.Show(resultaat, $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}