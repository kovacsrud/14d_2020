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

namespace WpfNevsorBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nevsor nevsorAdatok;
        public MainWindow()
        {
            InitializeComponent();
            nevsorAdatok = new Nevsor("tesztadat_20k.txt");
            //adatok.ItemsSource = nevsorAdatok.NevSor;
            adatok.DataContext = nevsorAdatok;
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            veznevDatagrid.DataContext = nevsorAdatok.VezetekNevKereses(textboxKereses.Text);
        }

        private void buttonKeresEv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                veznevDatagrid.DataContext = nevsorAdatok.EvKereses(Convert.ToInt32(textboxKereses.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
