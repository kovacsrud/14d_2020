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

namespace WpfDinamikusCimkek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Sokcimke(150);
        }

        public void Sokcimke(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Label cimke = new Label();
                cimke.Content = i + 1;
                cimke.FontSize = 14;
                cimke.Margin = new Thickness(3);

                elemek.Children.Add(cimke);
            }
            
        }

        public void LabelClick(object sender, RoutedEventArgs e)
        {
            Label cimke = (Label)sender;
            cimke.Foreground = Brushes.Red;
            cimke.Background = Brushes.Gold;

        }

    }
}
