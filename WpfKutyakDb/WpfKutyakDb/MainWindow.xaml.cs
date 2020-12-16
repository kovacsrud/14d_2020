using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace WpfKutyakDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public KutyafajtakSQL kutyafajtak;
        public MainWindow()
        {
            //CRUD->Create,Read,Update,Delete
            InitializeComponent();
            kutyafajtak = new KutyafajtakSQL("Data source=kutyak14d.db;version=3");
            //datagridKutyafajtak.ItemsSource = kutyafajtak.Kutyafajtak;
            datagridKutyafajtak.MouseDoubleClick += GridDblClick;
            datagridKutyafajtak.ItemsSource = kutyafajtak.kutyafajtakDT.DefaultView;
           
            
            
        }

        private void buttonUjKutyafajta_Click(object sender, RoutedEventArgs e)
        {
            UjKutyafajta ujkutyafajta = new UjKutyafajta(this);
            ujkutyafajta.ShowDialog();
        }

        private void GridDblClick(object sender,RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)datagridKutyafajtak.SelectedItem;
            Debug.WriteLine(row["id"]);
            Debug.WriteLine(row["nev"]);
            Debug.WriteLine(row["eredetinev"]);
            ModKutyafajta modkutyafajta = new ModKutyafajta(this,
                Convert.ToInt32(row["id"]),
                row["nev"].ToString(),
                row["eredetinev"].ToString());
            modkutyafajta.ShowDialog();

        }
       
    }
}
