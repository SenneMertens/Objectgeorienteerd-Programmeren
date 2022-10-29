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
using BMI_Models;

namespace BMI_WPF
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

        BMI bmi = null;

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaam.Text))
            {
                MessageBox.Show($"Voer een correcte naam in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (! double.TryParse(txtGewicht.Text, out double outGewicht) && ! double.TryParse(txtLengte.Text, out double outLengte))
            {
                MessageBox.Show($"Voer een correcte numerieke waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                double gewicht = double.Parse(txtGewicht.Text);
                double lengte = double.Parse(txtLengte.Text);
                bmi = new BMI(txtNaam.Text, gewicht, lengte);

                lblGegevens.Content = bmi.ToonGegevens();
                lblBMI.Content = $"Je BMI is {bmi.BerekenBMI():0.00}.";
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}