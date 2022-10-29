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
using Lamp_Models;

namespace Lamp_WPF
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

        Lamp lamp = null;

        private void UpdateLamp()
        {
            lblKleur.Background = lamp.LampKleur();
            lblResultaat.Content = lamp.ToonRGBWaardes();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lamp = new Lamp(125, 125, 125);
            UpdateLamp();
        }        

        private void BtnWillekeurig_Click(object sender, RoutedEventArgs e)
        {
            lamp.RandomKleur();
            UpdateLamp();
        }

        private void BtnMeerBlauw_Click(object sender, RoutedEventArgs e)
        {
            lamp.MeerBlauw();
            UpdateLamp();
        }

        private void BtnMinderBlauw_Click(object sender, RoutedEventArgs e)
        {
            lamp.MinderBlauw();
            UpdateLamp();
        }

        private void BtnMeerGroen_Click(object sender, RoutedEventArgs e)
        {
            lamp.MeerGroen();
            UpdateLamp();
        }

        private void BtnMinderGroen_Click(object sender, RoutedEventArgs e)
        {
            lamp.MinderGroen();
            UpdateLamp();
        }

        private void BtnMeerRood_Click(object sender, RoutedEventArgs e)
        {
            lamp.MeerRood();
            UpdateLamp();
        }

        private void BtnMinderRood_Click(object sender, RoutedEventArgs e)
        {
            lamp.MinderRood();
            UpdateLamp();
        }
    }
}