using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Microsoft.Win32;

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
            MakeHash(szoveg.Text);
        }

        private void MakeHash(string szoveg)
        {
            if (selectmd5.IsChecked == true)
            {

                hashszoveg.Text = hash.CreateHash(HashType.MD5, szoveg);
            }
            else if (selectsha1.IsChecked == true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA1, szoveg);
            }
            else if (selectsha256.IsChecked == true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA256, szoveg);
            }
            else if (selectsha384.IsChecked == true)
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA384, szoveg);
            }
            else
            {
                hashszoveg.Text = hash.CreateHash(HashType.SHA512, szoveg);
            }
        }

        private void buttonFajlHash_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog()==true)
            {
                //hashszoveg.Text = hash.CreateHash(HashType.MD5, dialog.FileName);
                MakeHash(dialog.FileName);
                Debug.WriteLine(dialog.FileName);
                var el = dialog.FileName.Split('\\');
                var fajlnev = el.Last().Split('.');
                var utvonal = "";
                for (int i = 0; i < el.Length-1; i++)
                {
                    utvonal += el[i]+"\\";
                }
                utvonal += fajlnev[0] + ".hash";
                Debug.WriteLine($"Útvonal:{utvonal}");

                File.WriteAllText(utvonal,hashszoveg.Text);
                if (szoveg.Text.Length>0)
                {
                    if (hashszoveg.Text.ToLower()==szoveg.Text.ToLower())
                    {
                        MessageBox.Show("A hash értéke megfelelő!");
                    } else
                    {
                        MessageBox.Show("A hash értéke nem megfelelő!");
                    }
                }
            }

        }
    }
}
