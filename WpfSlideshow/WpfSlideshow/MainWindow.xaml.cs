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

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000),DispatcherPriority.Normal,Kepvaltas,Dispatcher.CurrentDispatcher);
            timer.Stop();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            if (openDialog.ShowDialog()==true)
            {
                fajlok = openDialog.FileNames;
                timer.Start();
            }
            
        }

        private void Kepvaltas(object sender,EventArgs e)
        {

        }
    }
}
