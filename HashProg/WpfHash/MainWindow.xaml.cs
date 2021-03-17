using System;
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
using HashCreate;

namespace WpfHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        HashCreator hash;
        public MainWindow()
        {
            InitializeComponent();
            hash = new HashCreator();
            
        }

        private void buttonHash_Click(object sender, RoutedEventArgs e)
        {
            if (selectmd5.IsChecked==true)
            {
                //md5
                hashszoveg.Text = hash.CreateHash(HashType.MD5, szoveg.Text);
            }
            else if (selectsha1.IsChecked==true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA1, szoveg.Text);
            }
            else if(selectsha256.IsChecked==true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA256,szoveg.Text);
            } else if(selectsha384.IsChecked==true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA384,szoveg.Text);
            } else
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA512, szoveg.Text);
            }
        }
    }
}
