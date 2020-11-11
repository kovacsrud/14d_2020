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
using System.Windows.Threading;

namespace WpfSlideshow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openDialog;
        string[] fajlok;
        DispatcherTimer timer;
        int szamlalo;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000),DispatcherPriority.Normal,Kepvaltas,Dispatcher.CurrentDispatcher);
            timer.Stop();
            szamlalo = 0;
            buttonStartStop.IsEnabled = false;
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            if (openDialog.ShowDialog()==true)
            {
                fajlok = openDialog.FileNames;
                timer.Start();
                buttonStartStop.IsEnabled = true;
                buttonStartStop.Content = "Stop";
            }
            
        }

        private void Kepvaltas(object sender,EventArgs e)
        {
            kep.Source = new BitmapImage(new Uri(fajlok[szamlalo]));
            szamlalo++;
            if (szamlalo>=fajlok.Length)
            {
                szamlalo = 0;
            }
        }

        private void buttonStartStop_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
                buttonStartStop.Content = "Start";
            } else
            {
                timer.Start();
                buttonStartStop.Content = "Stop";
            }
        }
    }
}
