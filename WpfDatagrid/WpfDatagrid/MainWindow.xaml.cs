﻿using System;
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

namespace WpfDatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nevsor nevsor;

        public MainWindow()
        {
            InitializeComponent();
            nevsor = new Nevsor("nevsor_20k.txt");
            Debug.WriteLine(nevsor.NevSor.Count);
            datagridAdatok.ItemsSource = nevsor.NevSor;
        }
    }
}
