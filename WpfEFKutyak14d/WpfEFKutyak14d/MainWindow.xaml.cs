using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfEFKutyak14d
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaModel kutyamodel;
        public MainWindow()
        {
            InitializeComponent();
            kutyamodel = new KutyaModel();
            kutyamodel.kutya.Load();
            kutyamodel.kutyanevek.Load();
            kutyamodel.kutyafajtak.Load();
            DataContext = kutyamodel;
            //datagridKutya.ItemsSource=kutyamodel.kutya.Local;
        }

        private void buttonFajtaUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }


        private void buttonNevUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }

        private void buttonKezelesUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }
        private void DbUpdate()
        {
            var muvelet = kutyamodel.SaveChanges();
            if (muvelet > 0)
            {
                MessageBox.Show("Sikeres update!");
            }
            else
            {
                MessageBox.Show("Nem történt változás!");
            }
        }

       
    }
}
