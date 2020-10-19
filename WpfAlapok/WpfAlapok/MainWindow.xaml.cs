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

namespace WpfAlapok
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(textboxA.Text);
                var b = Convert.ToInt32(textboxB.Text);
                var c = (double)a / b;
                labelEredmeny.Content = c;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Számot kell megadni", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("0-val ne osszunk már!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
