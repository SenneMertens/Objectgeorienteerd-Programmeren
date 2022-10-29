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

namespace Dobbelsteen_WPF
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

        private void BtnGooien_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int willekeurigGetal1;
            int willekeurigGetal2;

            willekeurigGetal1 = random.Next();
            willekeurigGetal2 = random.Next();

            lblGetal1.Content = willekeurigGetal1.ToString();
            lblGetal2.Content = willekeurigGetal2.ToString();
        }
    }
}