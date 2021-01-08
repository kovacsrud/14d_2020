using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace WpfKutyaAdapter
{
    public class FajtaAdapter
    {
        string connString;
        DataTable fajtaadatok;
        public DataView Fajtaadatok { get { return fajtaadatok.DefaultView; } }
        SQLiteDataAdapter adapter;
        SQLiteConnection conn;

        public FajtaAdapter()
        {

        }
    }
}