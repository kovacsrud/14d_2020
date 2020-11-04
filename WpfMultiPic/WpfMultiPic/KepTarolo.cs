using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfMultiPic
{
    public class KepTarolo:StackPanel
    {
        BitmapImage bitmap;
        Image kep;
        TextBlock kepAlairas;

        public KepTarolo(string fajl)
        {
            try
            {
                bitmap = new BitmapImage(new Uri(fajl));
                kep = new Image();
                kep.Source = bitmap;
                this.Children.Add(kep);
                kepAlairas = new TextBlock();
                kepAlairas.Text = fajl;
                kepAlairas.TextWrapping = TextWrapping.Wrap;
                kepAlairas.HorizontalAlignment = HorizontalAlignment.Center;
                this.Children.Add(kepAlairas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }
        }
    }
}
