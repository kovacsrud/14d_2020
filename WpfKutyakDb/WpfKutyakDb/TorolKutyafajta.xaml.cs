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
    /// Interaction logic for TorolKutyafajta.xaml
    /// </summary>
    public partial class TorolKutyafajta : Window
    {
        MainWindow mainwindow;
        private int id;
        public TorolKutyafajta()
        {
            InitializeComponent();
        }

        public TorolKutyafajta(MainWindow atvettablak, int id, string nev, string eredetinev)
        {
            InitializeComponent();
            mainwindow = atvettablak;
            this.id = id;

            textblockNev.Text = nev;
            textblockEredetinev.Text = eredetinev;
        }

        private void buttonDeletefajta_Click(object sender, RoutedEventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan törli?", "Törlés", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (valasz == MessageBoxResult.Yes)
            {
                mainwindow.kutyafajtak.TorolKutyafajta(id);

                textblockNev.Text = "";
                textblockEredetinev.Text = "";

            }
            else
            {
                MessageBox.Show("Nincs törlés", "Törlés", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
