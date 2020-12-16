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
    /// Interaction logic for ModKutyafajta.xaml
    /// </summary>
    public partial class ModKutyafajta : Window
    {
        MainWindow mainwindow;
        private int id;
       

        public ModKutyafajta()
        {
            InitializeComponent();
        }

        public ModKutyafajta(MainWindow atvettablak,int id,string nev,string eredetinev)
        {
            InitializeComponent();
            mainwindow = atvettablak;
            this.id = id;
           
            textboxNev.Text = nev;
            textboxEredetinev.Text = eredetinev;
        }

        private void buttonUpdatefajta_Click(object sender, RoutedEventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan módosítja?", "Adatmódosítás", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (valasz == MessageBoxResult.Yes)
            {
                mainwindow.kutyafajtak.ModositKutyafajta(id,textboxNev.Text,textboxEredetinev.Text);

                textboxNev.Text = "";
                textboxEredetinev.Text = "";

            }
            else
            {
                MessageBox.Show("Nincs módosítás", "Adatmódosítás", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
