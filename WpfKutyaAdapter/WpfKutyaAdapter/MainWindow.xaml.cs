﻿using System;
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

namespace WpfKutyaAdapter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaAdapter kutyaadapter;
        public MainWindow()
        {
            InitializeComponent();
            kutyaadapter = new KutyaAdapter("Data Source=kutyak14d.db;Version=3");
            DataContext = kutyaadapter;

            //dataGridKutyanevek.ItemsSource = kutyaadapter.nevadapter.Nevadatok;
            //dataGridKutyafajtak.ItemsSource = kutyaadapter.fajtaadapter.Fajtaadatok;

        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            kutyaadapter.nevadapter.UpdateKutyanevek();
        }

        private void buttonUpdateFajtak_Click(object sender, RoutedEventArgs e)
        {
            kutyaadapter.fajtaadapter.UpdateKutyafajtak();
        }

        private void buttonUpdateKezelesek_Click(object sender, RoutedEventArgs e)
        {
            kutyaadapter.kezelesadapter.UpdateKutyak();
        }
    }
}
