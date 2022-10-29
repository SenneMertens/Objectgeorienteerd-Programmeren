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
using TV_DAL;
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

        List<TVKanaal> kanalen = new List<TVKanaal>();

        TVKanaal een = new TVKanaal(1, $"Een");
        TVKanaal canvas = new TVKanaal(2, $"Canvas");
        TVKanaal vtm = new TVKanaal(3, $"VTM");
        TVKanaal vier = new TVKanaal(4, $"Vier");
        TVKanaal vijf = new TVKanaal(5, $"Vijf");

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            kanalen.Add(een);
            kanalen.Add(canvas);
            kanalen.Add(vtm);
            kanalen.Add(vier);
            kanalen.Add(vijf);

            cmbKanaal.ItemsSource = kanalen;
            cmbKanaal.DisplayMemberPath = $"Omschrijving";
        }
          
        private void CmbKanaal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblResultaat.Content = kanalen[cmbKanaal.SelectedIndex].ToString();
        }
    }
}
