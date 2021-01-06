using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace WpfKutyaAdapter
{
    public class NevAdapter
    {
        string connString;
        DataTable nevadatok;
        public DataView Nevadatok { get { return nevadatok.DefaultView; } }
        SQLiteDataAdapter adapter;
        SQLiteConnection conn;

        public NevAdapter(string connstring)
        {
            connString = connstring;
            nevadatok = new DataTable();
            conn = new SQLiteConnection(connString);
            adapter = new SQLiteDataAdapter("",conn);

            adapter.SelectCommand.CommandText = "select * from kutyanevek";
        }


    }
}
