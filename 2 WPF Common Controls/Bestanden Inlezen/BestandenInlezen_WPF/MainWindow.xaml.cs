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
using System.IO;

namespace BestandenInlezen_WPF
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

        private void CbGeldigeRecords_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CbFoutieveRecords_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAfdrukken_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding, resultaat;
            int aantalCorrect;

            StreamReader reader = new StreamReader("records.txt");

            aantalCorrect = 0;
            lblGeldigeRecords.Content = $"";
            lblOngeldigeRecords.Content = $"";

            while (! reader.EndOfStream)
            {
                string lijn = reader.ReadLine();

                if (GegevensControle(lijn, out foutmelding, out resultaat))
                {
                    if (cbGeldigeRecords.IsChecked == true)
                    {
                        lblGeldigeRecords.Content += resultaat;
                    }                    
                    aantalCorrect++;
                }
                else
                {
                    if (cbFoutieveRecords.IsChecked == true)
                    {
                        lblOngeldigeRecords.Content = foutmelding;
                    }                    
                }                                               
            }

            if (cbGeldigeRecords.IsChecked == true)
            {
                lblGeldigeRecords.Content += $"Aantal geldige records: {aantalCorrect}";
            }

            reader.Close();
        }

        private bool GegevensControle(string lijn, out string foutmelding, out string resultaat)
        {
            foutmelding = string.Empty;
            resultaat = string.Empty;

            string[] gegevens = lijn.Split(';');

            foutmelding += $"{gegevens[3]}:{Environment.NewLine}";

            if (! int.TryParse(gegevens[0], out int getal))
            {
                foutmelding += $"\tFoutieve nummer{Environment.NewLine}";
            }
            if (double.TryParse(gegevens[1], out double naam))
            {
                foutmelding += $"\tFoutieve naam{Environment.NewLine}";
            }
            if (gegevens[2].ToUpper() != "M" && gegevens[2].ToUpper() != "V")
            {
                foutmelding += $"\tFoutief geslacht{Environment.NewLine}";
            }
            if (! gegevens[3].Contains("@") || !gegevens[3].Contains("."))
            {
                foutmelding += $"\tFoutieve e-mail{Environment.NewLine}";
            }
            if (! int.TryParse(gegevens[4], out int leeftijd))
            {
                foutmelding += $"\tFoutieve leeftijd{Environment.NewLine}";
            }
            if (foutmelding == $"{gegevens[3]}:{Environment.NewLine}")
            {
                return false;
            }
            else
            {
                resultaat = $"{gegevens[3]}:{Environment.NewLine}";
                return true;
            }
        }
    }
}