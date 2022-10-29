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
using Dieren_DAL;
using Dieren_Models;

namespace Dieren_WPF
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

        List<string> dierenLijst = new List<string>();

        private void BtnLezenEnAfdrukken_Click(object sender, RoutedEventArgs e)
        {
            FileReader filereader = new FileReader();

            dierenLijst.AddRange(filereader.BestandLezen("dieren.txt"));

            lbResultaat.ItemsSource = dierenLijst;
            lbResultaat.Items.Refresh();
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (! string.IsNullOrEmpty(txtDier.Text))
            {
                if (! dierenLijst.Contains(txtDier.Text))
                {
                    dierenLijst.Add(txtDier.Text);
                    lbResultaat.Items.Refresh();
                }
                else
                {
                    MessageBox.Show($"{txtDier.Text} zit al in de lijst.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Voer een correcte waarde in.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            dierenLijst.Clear();
            lbResultaat.Items.Refresh();
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (lbResultaat.SelectedItem is string dier)
            {
                dierenLijst.Remove(dier);
            }

            lbResultaat.Items.Refresh();
        }

        private void BtnSorteren_Click(object sender, RoutedEventArgs e)
        {
            dierenLijst.Sort();
            lbResultaat.Items.Refresh();
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}