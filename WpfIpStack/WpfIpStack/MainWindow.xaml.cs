﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfIpStack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JObject jsonData;

        String apiKey = "57e7f2daa88da7119dc6c575f1232c0f";
        String weatherApiKey = "cee47ae14c4e2b23dd70220929479c28";

        public MainWindow()
        {
            InitializeComponent();
            
                        
        }

        public TextBlock DataToTextBlock(string data,int fontsize)
        {
            TextBlock textData = new TextBlock();
            textData.Text = data;
            textData.FontSize = fontsize;

            return textData;
        }

        public void GetData(string ipAddress)
        {
            jsonData = JObject.Parse(new WebClient().DownloadString($"http://api.ipstack.com/{ipAddress}?access_key={apiKey}"));
        }

        public BitmapImage KepFromUrl(string address)
        {
            WebClient kepclient = new WebClient();
            byte[] kepdata = kepclient.DownloadData(address);

            MemoryStream ms = new MemoryStream(kepdata);

            BitmapImage bitmapKep = new BitmapImage();
            bitmapKep.BeginInit();
            bitmapKep.StreamSource = ms;
            bitmapKep.EndInit();

            return bitmapKep;

        }

        private void buttonIp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GetData(textBoxIp.Text);
                Debug.WriteLine(jsonData);
                apiAdatok.Children.Clear();
                apiAdatok.Children.Add(DataToTextBlock((string)jsonData["ip"], 20));
                apiAdatok.Children.Add(DataToTextBlock((string)jsonData["continent_name"], 20));
                apiAdatok.Children.Add(DataToTextBlock((string)jsonData["country_name"], 30));
                apiAdatok.Children.Add(DataToTextBlock((string)jsonData["region_name"], 20));
                imageNetKep.Source = KepFromUrl("https://taszi.hu/kepek/kepkezelo/large/2828.jpg");
            }
            catch(Newtonsoft.Json.JsonReaderException ex)
            {
                MessageBox.Show("Üres az IP cím!","Hiba",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
         
            
            
            //https://taszi.hu/kepek/kepkezelo/large/2828.jpg
        }
    }
}
