using Microsoft.Win32;
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

namespace WpfVG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData gamedata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    gamedata = new GameData(dialog.FileName, ';', 1);
                    MessageBox.Show($"Sikeres betöltés,sorok száma:{gamedata.Games.Count}");
                    comboPlatform.ItemsSource = gamedata.GetPlatforms();
                    comboboxKategoria.ItemsSource = gamedata.GetKategoria();
                    tabPlatform.IsEnabled = true;
                    tabKereses.IsEnabled = true;
                    tabStatisztika.IsEnabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }

        }

        private void comboPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = comboPlatform.SelectedValue.ToString();
            var eredmeny = gamedata.Games.FindAll(x=>x.Platform==selected);
            datagridPlatform.ItemsSource = eredmeny;
           
        }

        private void buttonKereses_Click(object sender, RoutedEventArgs e)
        {
            var jateknev = textboxKereses.Text;
            datagridKereses.ItemsSource = null;
            datagridKereses.Items.Clear();
            //var eredmeny = gamedata.Games.FindAll(x=>x.Name.ToLower()==jateknev.ToLower());
            var eredmeny = gamedata.Games.FindAll(x=>x.Name.Replace(" ","").ToLower().Contains(jateknev.Replace(" ","").ToLower()));
            

            if (eredmeny.Count==0)
            {
                MessageBox.Show("Nincs a kifejezésnek megfelelő találat!","Info",MessageBoxButton.OK,MessageBoxImage.Information);
            } else
            {
                datagridKereses.ItemsSource = eredmeny;

            }
        }

        private void comboboxKategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = comboboxKategoria.SelectedValue.ToString();
            var eredmeny = gamedata.Games.FindAll(x=>x.Genre==selected);
            datagridEladasok.ItemsSource = eredmeny;
            var minEladas = eredmeny.Min(x => x.Globalsales);
            textblockMinSale.Text = $"{minEladas} millió";
            var maxEladas = eredmeny.Max(x=>x.Globalsales);
            textblockMaxnSale.Text = $"{maxEladas} millió";
            var avgEladas = eredmeny.Average(x => x.Globalsales);
            textblockAvgSale.Text = $"{avgEladas:0.00} millió";
            var sumEladas = eredmeny.Sum(x=>x.Globalsales);
            textblockSumSale.Text = $"{sumEladas:0.00} millió";

        }
    }
}
