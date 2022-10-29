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

namespace Maaltafel_WPF
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
            lblResultaat.Content = $"";

            if (! int.TryParse(txtGetal.Text, out int getal))
            {
                lblResultaat.Content = $"Voer een geldige numerieke waarde in.";
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    lblResultaat.Content += $"{i} x {getal} = {i * getal}\n";
                }
            }
        }
    }
}