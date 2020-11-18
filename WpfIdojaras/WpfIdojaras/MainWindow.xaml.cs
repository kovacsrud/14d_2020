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

namespace WpfIdojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IdojarasAdatok idojarasadatok;
        public MainWindow()
        {
            InitializeComponent();
            idojarasadatok = new IdojarasAdatok("idojaras.csv");
            listboxEv.ItemsSource = idojarasadatok.GetEvek();
            listboxEv.SelectionChanged += KivalasztottEv;
        }

        private void KivalasztottEv(object sender,RoutedEventArgs e)
        {
            datagridAdatok.ItemsSource = idojarasadatok.GetAdatok(Convert.ToInt32(listboxEv.SelectedItem));
            listboxHonap.ItemsSource = idojarasadatok.GetHonapok(Convert.ToInt32(listboxEv.SelectedItem));
        }
    }
}
