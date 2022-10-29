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

        Student student = new Student();

        private void BtnTonen_Click(object sender, RoutedEventArgs e)
        {
            if (! int.TryParse(txtInformatica.Text, out int puntenInformatica) || ! int.TryParse(txtWiskunde.Text, out int puntenWiskunde))
            {
                MessageBox.Show($"Foutieve numerieke waarde.", $"Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtNaam.Text))
                {
                    student.Naam = txtNaam.Text;
                }
                else
                {
                    student.Naam = $"...";
                }

                student.PuntenInformatica = puntenInformatica;
                student.PuntenWiskunde = puntenWiskunde;

                txtResultaat.Text = student.ToonGegevens();
            }
        }
    }
}