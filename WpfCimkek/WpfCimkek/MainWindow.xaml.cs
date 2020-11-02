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

namespace WpfCimkek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Soklabel(50);
        }

        public void Soklabel(int db)
        {
            elemek.Children.Clear();
            for (int i = 0; i < db; i++)
            {
                Label label = new Label();
                label.Content = i + 1;
                label.FontSize = 16;
                elemek.Children.Add(label);
            }
        }

        private void BalClick(object sender,RoutedEventArgs e)
        {

        }

        private void JobbClick(object sender, RoutedEventArgs e)
        {

        }


        private void buttonLetrehoz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Soklabel(Convert.ToInt32(textBoxDarab.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
            
        }
    }
}
