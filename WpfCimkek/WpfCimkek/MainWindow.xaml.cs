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
            for (int i = 0; i < db; i++)
            {
                Label label = new Label();
                label.Content = i + 1;
                label.FontSize = 16;
                elemek.Children.Add(label);
            }
        }
    }
}
