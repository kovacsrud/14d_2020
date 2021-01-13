using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace WpfKutyaAdapter
{
    public class KezelesAdapter
    {
        string connString;
        DataTable kezelesadatok;
        public DataView Kezelesadatok { get { return kezelesadatok.DefaultView; } }
        SQLiteDataAdapter adapter;
        SQLiteConnection conn;

        public KezelesAdapter(string connstring)
        {
            connString = connstring;
            kezelesadatok = new DataTable();
            conn = new SQLiteConnection(connString);
            adapter = new SQLiteDataAdapter("", conn);

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from kutyak";

            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into kutyak " +
                "(fajtaid,nevid,eletkor,utolsoell) " +
                "values (@fajtaid,@nevid,@eletkor,@utolsoell)";
            adapter.InsertCommand.Parameters.Add("@fajtaid",DbType.Int32,0,"fajtaid");
            adapter.InsertCommand.Parameters.Add("@nevid",DbType.Int32,0,"nevid");
            adapter.InsertCommand.Parameters.Add("@eletkor", DbType.Int32, 0, "eletkor");
            adapter.InsertCommand.Parameters.Add("@utolsoell", DbType.Int32, 0, "utolsoell");
        }

    }
}