using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfKutyakDb
{
    public class KutyafajtakSQL
    {
        public class Kutyafajta
        {
            public int Id { get; set; }
            public string Nev { get; set; }
            public string Eredetinev { get; set; }

        }

        public DataTable kutyafajtakDT;

        private string connString = "";

        private List<Kutyafajta> kutyafajtak;
        public List<Kutyafajta> Kutyafajtak { get { return kutyafajtak; }  }

        public KutyafajtakSQL(string connString)
        {
            this.connString = connString;
            kutyafajtak = new List<Kutyafajta>();
            kutyafajtakDT = new DataTable();
            ModositKutyafajta(423);
            //TorolKutyafajta(422);
            Lekerdezes();
            LekerdezesDT();
            //UjKutyafajta();
            

        }

        private void Lekerdezes()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand comm = new SQLiteCommand(conn))
                {
                    comm.CommandText = "select * from kutyafajtak";

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                kutyafajtak.Add(
                                    new Kutyafajta
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        Nev = reader["nev"].ToString(),
                                        Eredetinev = reader["eredetinev"].ToString()
                                    }
                                    );
                            }

                        }
                        else
                        {
                            MessageBox.Show("Nincs találat!");
                        }
                    }

                }
            }
        }

        private void LekerdezesDT()
        {
            using (SQLiteConnection conn=new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand comm=new SQLiteCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "select * from kutyafajtak";
                    using (SQLiteDataReader reader=comm.ExecuteReader())
                    {
                        kutyafajtakDT.Load(reader);
                    }

                }
            }
        }

        public void UjKutyafajta(string nev,string eredetinev)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand comm=new SQLiteCommand(conn))
                {
                    comm.CommandText = $"INSERT INTO kutyafajtak (nev,eredetinev) values(@nev,@eredetinev)";
                    comm.Parameters.Add("@nev", DbType.String).Value = nev;
                    comm.Parameters.Add("@eredetinev", DbType.String).Value = eredetinev;

                    var beszurtsor=comm.ExecuteNonQuery();
                    Debug.WriteLine(beszurtsor);

                }
            }
        }

        public void ModositKutyafajta(int id)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand comm=new SQLiteCommand(conn))
                {
                    comm.CommandText = "UPDATE kutyafajtak SET nev=@nev,eredetinev=@eredetinev WHERE id=@id";
                    comm.Parameters.Add("@nev", DbType.String).Value = "Kuvasz";
                    comm.Parameters.Add("@eredetinev", DbType.String).Value = "Kuvasz";
                    comm.Parameters.Add("@id", DbType.Int32).Value = id;

                    var modositottsor = comm.ExecuteNonQuery();
                    Debug.WriteLine(modositottsor);
                }
            }
        }

        public void TorolKutyafajta(int id)
        {
            using (SQLiteConnection conn=new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteCommand comm=new SQLiteCommand(conn))
                {
                    comm.CommandText = "DELETE FROM kutyafajtak WHERE id=@id";
                    comm.Parameters.Add("@id", DbType.Int32).Value = id;
                    var toroltsor = comm.ExecuteNonQuery();
                    Debug.WriteLine(toroltsor);
                }
            }
        }


    }
}
