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
using TV_Models;

namespace TV_WPF
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

        TV televisie = new TV();

        private void BtnVermeerder_Click(object sender, RoutedEventArgs e)
        {
            televisie.VermeerderKanaal();
            televisie.VermeerderVolume();

            lblResultaat.Content = televisie.ToonGegevens();
        }

        private void BtnVerminder_Click(object sender, RoutedEventArgs e)
        {
            televisie.VerminderKanaal();
            televisie.VerminderVolume();

            lblResultaat.Content = televisie.ToonGegevens();
        }
    }
}