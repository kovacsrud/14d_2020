using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTwoWayBind
{
    public class BindOsztaly:INotifyPropertyChanged
    {
        private int bindadat;
        public int BindAdat {
            get { return bindadat; }
            set
            {
                if (value!=bindadat && value>=0 && value<=100)
                {
                    bindadat = value;
                    Prop_Changed("BindAdat");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Prop_Changed(string propnev)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propnev));
            }
        }
    }
}
