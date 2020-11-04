﻿using Microsoft.Win32;
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

namespace WpfKep
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "képfájlok (*.jpg;*.jpeg;*.gif)|*.jpg;*.jpeg;*.gif|minden fájl (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.InitialDirectory="d:\\";
            
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(dialog.FileName));
                    kep.Source = bitmap;
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show("Nem támogatott fájl!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);

                }
              
            }
        }
    }
}
