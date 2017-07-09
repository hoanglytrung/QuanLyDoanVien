using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanVien
{
    public class Account
    {
        public Account()
        {

        }

        public void Update_Password()
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            SQLiteCommand sqlite_cmd;
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "select Pass from admin_acc where ID = '" + this.ID + "';";
            this.Pass = Convert.ToString(sqlite_cmd.ExecuteScalar());
            //sqlite_cmd.CommandText = "select User from admin_acc where ID = '" + this.ID + "';";
            //this.User = Convert.ToString(sqlite_cmd.ExecuteScalar());
            //sqlite_cmd.CommandText = "select Level from admin_acc where ID = '" + this.ID + "';";
            //this.Level = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

            sqlite_conn.Close();
        }
        public int ID { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public int Level { get; set; }
    }
}
