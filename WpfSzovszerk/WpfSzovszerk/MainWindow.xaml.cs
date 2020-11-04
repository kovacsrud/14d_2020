using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfSzovszerk
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

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == true)
                {
                    szoveg.Text = File.ReadAllText(dialog.FileName, Encoding.Default);
                    this.Title = dialog.FileName.Split('\\').Last();
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                MessageBox.Show("A mappa nem található!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("A fájl nem található!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
            
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog()==true)
                {
                    File.WriteAllText(dialog.FileName, szoveg.Text, Encoding.Default);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
        }
    }
}
