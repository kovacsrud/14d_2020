using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
            GetData("82.144.165.119");
            Debug.WriteLine(jsonData["country_name"]);
            Debug.WriteLine(jsonData["region_code"]);
            Debug.WriteLine(jsonData["region_name"]);
            Debug.WriteLine(jsonData["city"]);
            apiAdatok.Children.Add(DataToTextBlock((string)jsonData["country_name"],30));
            apiAdatok.Children.Add(DataToTextBlock((string)jsonData["region_name"], 20));
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
    }
}
