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

        public FajtaAdapter(string connstring)
        {
            connString = connstring;
            fajtaadatok = new DataTable();
            conn = new SQLiteConnection(connString);
            adapter = new SQLiteDataAdapter("", conn);

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from kutyafajtak";

            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into kutyafajtak " +
                "(nev,eredetinev) " +
                "values (@nev,@eredetinev)";
            adapter.InsertCommand.Parameters.Add("@nev",DbType.String,0,"nev");
            adapter.InsertCommand.Parameters.Add("@eredetinev",DbType.String,0,"eredetinev");

            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "update kutyafajtak set " +
                "nev=@nev,eredetinev=@eredetinev " +
                "where id=@id";
            adapter.UpdateCommand.Parameters.Add("@nev", DbType.String, 0, "nev");
            adapter.UpdateCommand.Parameters.Add("@eredetinev", DbType.String, 0, "eredetinev");
            adapter.UpdateCommand.Parameters.Add("@id",DbType.Int32,0,"id").SourceVersion=DataRowVersion.Original;

            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "delete from kutyafajtak where id=@id";
            adapter.DeleteCommand.Parameters.Add("@id", DbType.Int32, 0, "id").SourceVersion = DataRowVersion.Original;

            adapter.Fill(fajtaadatok);
        }

        public void UpdateKutyafajtak()
        {
            adapter.Update(fajtaadatok);
            fajtaadatok.Clear();
            adapter.Fill(fajtaadatok);
        }
    }
}