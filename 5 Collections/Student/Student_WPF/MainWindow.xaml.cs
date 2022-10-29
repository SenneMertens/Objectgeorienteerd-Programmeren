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
using Student_DAL;
using Student_Models;

namespace Student_WPF
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

        List<string> studenten = new List<string>();
        List<int> punten = new List<int>();
        List<string> resultaat = new List<string>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbResultaat.ItemsSource = resultaat;
        }

        private void BtnStudentenLezen_Click(object sender, RoutedEventArgs e)
        {
            FileReader filereader = new FileReader();

            studenten.AddRange(filereader.LeesString("studenten.txt"));

            resultaat.AddRange(studenten);
          
            lbResultaat.Items.Refresh();
        }

        private void BtnPuntenLezen_Click(object sender, RoutedEventArgs e)
        {
            FileReader filereader = new FileReader();

            punten.AddRange(filereader.LeesInt("punten.txt"));

            resultaat.AddRange(filereader.LeesString("punten.txt"));

            lbResultaat.Items.Refresh();
        }

        private void BtnResultaat_Click(object sender, RoutedEventArgs e)
        {
            int geslaagden, gebuisden;

            geslaagden = 0;
            gebuisden = 0;

            if (studenten.Count > 0 || punten.Count > 0)
            {
                for (int i = 0; i < studenten.Count; i++)
                {
                    if (punten[i] >= 50)
                    {
                        resultaat.Add($"{studenten[i].PadRight(15)}{punten[i].ToString().PadLeft(5)}" + "".PadLeft(5) + "Geslaagd");
                        geslaagden++;
                    }
                    else
                    {
                        resultaat.Add($"{studenten[i].PadRight(15)}{punten[i].ToString().PadLeft(5)}" + "".PadLeft(5) + "Niet Geslaagd");
                        gebuisden++;
                    }
                }

                resultaat.Add($"Aantal geslaagden: {geslaagden}{Environment.NewLine}Aantal gebuisden: {gebuisden}");

                lbResultaat.Items.Refresh();
            }
            else
            {
                MessageBox.Show($"Zowel studenten als punten moeten eerst ingelezen worden.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            studenten.Clear();
            punten.Clear();
            resultaat.Clear();
            lbResultaat.Items.Refresh();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}