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
using System.Windows.Shapes;

namespace WpfKutyakDb
{
    /// <summary>
    /// Interaction logic for UjKutyafajta.xaml
    /// </summary>
    public partial class UjKutyafajta : Window
    {
        MainWindow mainwindow;
        public UjKutyafajta()
        {
            InitializeComponent();
        }

        public UjKutyafajta(MainWindow atvettablak)
        {
            InitializeComponent();
            mainwindow = atvettablak;
        }

        private void buttonInsertUjfajta_Click(object sender, RoutedEventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan rögzíti?", "Új adat felvitele", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (valasz==MessageBoxResult.Yes)
            {
                mainwindow.kutyafajtak.UjKutyafajta(textboxNev.Text, textboxEredetinev.Text);
                
                textboxNev.Text = "";
                textboxEredetinev.Text = "";

            } else
            {
                MessageBox.Show("Nincs rögzítés", "Új adat felvitele", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
            
        }
    }
}
