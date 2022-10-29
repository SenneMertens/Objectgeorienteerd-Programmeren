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
using Ministers_DAL;
using Ministers_Models;

namespace Ministers_WPF
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

        List<string> ministers = new List<string>();
        List<int> stemmen = new List<int>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FileReader filereader = new FileReader();
            
            ministers.AddRange(filereader.BestandLezen("ministers.txt"));

            foreach (var item in ministers)
            {
                stemmen.Add(0);
            }

            cmbMinisters.ItemsSource = ministers;
            cmbMinisters.Items.Refresh();
        }

        private void BtnUitslag_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ministers.Count; i++)
            {
                lblResultaat.Content += $"{ministers[i]} - Stemmen: {stemmen[i]}{Environment.NewLine}";
            }
        }

        private void BtnStemmen_Click(object sender, RoutedEventArgs e)
        {
            lblResultaat.Content = $"";

            if (cmbMinisters.SelectedIndex != -1)
            {
                stemmen[cmbMinisters.SelectedIndex]++;
            }
            else
            {
                MessageBox.Show($"Selecteer een minister.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}