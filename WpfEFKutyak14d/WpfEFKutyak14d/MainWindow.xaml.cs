﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfEFKutyak14d
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaModel kutyamodel;
        public MainWindow()
        {
            InitializeComponent();
            kutyamodel = new KutyaModel();
            kutyamodel.kutya.Load();
            kutyamodel.kutyanevek.Load();
            kutyamodel.kutyafajtak.Load();
            DataContext = kutyamodel;
            //datagridKutya.ItemsSource=kutyamodel.kutya.Local;
        }
    }
}
