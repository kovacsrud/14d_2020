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

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from kutyanevek";
            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into kutyanevek (kutyanev)" +
                " values (@kutyanev)";
            adapter.InsertCommand.Parameters.Add("@kutyanev",DbType.String,0,"kutyanev");
            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "update kutyanevek set kutyanev=@kutyanev where id=@id";
            adapter.UpdateCommand.Parameters.Add("@kutyanev", DbType.String, 0, "kutyanev");
            adapter.UpdateCommand.Parameters.Add("@id", DbType.Int32, 0, "id").SourceVersion = DataRowVersion.Original;
            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "delete from kutyanevek where id=@id";
            adapter.DeleteCommand.Parameters.Add("@id",DbType.Int32,0,"id").SourceVersion=DataRowVersion.Original;

            adapter.Fill(nevadatok);

        }

        public void UpdateKutyanevek()
        {
            adapter.Update(nevadatok);
            nevadatok.Clear();
            adapter.Fill(nevadatok);
        }
    }
}
