using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.SQLite;
namespace QuanLyDoanVien
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
        SQLiteCommand sqlite_cmd;

        Account current_acc = new Account();
        
        public Login()
        {
            InitializeComponent();
            sqlite_conn.Open();
        }


        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "select Pass from admin_acc where User = '" + tb_username.Text + "';";
            current_acc.Pass = Convert.ToString(sqlite_cmd.ExecuteScalar());

            if (current_acc.Pass == ps_password.Password.ToString())
            {
                sqlite_cmd.CommandText = "select ID from admin_acc where User = '" + tb_username.Text + "';";
                current_acc.ID = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
                sqlite_cmd.CommandText = "select User from admin_acc where ID = '" + current_acc.ID + "';";
                current_acc.User = Convert.ToString(sqlite_cmd.ExecuteScalar());
                sqlite_cmd.CommandText = "select Level from admin_acc where ID = '" + current_acc.ID + "';";
                current_acc.Level = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                //MessageBox.Show(current_acc.ID.ToString() + " " + current_acc.User + " " + current_acc.Pass + current_acc.Level);

                this.Hide();
                MainWindow ss = new MainWindow(current_acc);
                //Change_Pass cp = new Change_Pass(current_acc);
                ss.Show();
                sqlite_conn.Close();
                this.Close();
            }
            else if (tb_username.Text == "" && ps_password.Password.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập Username và Password");
            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng");
            }
        }



        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            sqlite_conn.Close();
            this.Close();
        }
    }
}
