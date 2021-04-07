using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace Mintavizsga2020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutoLista autolista;
        public MainWindow()
        {
            InitializeComponent();
            // Vészhelyzeti megoldás, ha nem megy
            //párbeszédablakkal
            //autolista = new AutoLista("valami.txt",';',1);



        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog()==true)
            {
                autolista = new AutoLista(dialog.FileName,';',1);
                tabKereses.IsEnabled = true;
                tabUjadat.IsEnabled = true;
            }
            Debug.WriteLine(autolista.Autok.Count);
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var alsoAr = Convert.ToInt32(textboxAlsoAr.Text);
                var felsoAr = Convert.ToInt32(textboxFelsoAr.Text);
                var eredmeny = autolista.Autok.FindAll(x => x.Ar >= alsoAr && x.Ar <= felsoAr);
                if (eredmeny.Count<1)
                {
                    throw new ArgumentException("Nincs a feltételeknek megfelelő adat!");
                }
                datagridAdatok.ItemsSource = eredmeny;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
