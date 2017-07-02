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
    /// Interaction logic for Create_Admin_Account.xaml
    /// </summary>
    public partial class Create_Admin_Account : Window
    {
        public Create_Admin_Account()
        {
            InitializeComponent();
        }
        private string User_name;
        private string Password;
        private string Confirm_Password;
        bool Compare_password = false;


        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            if (tb_UserName.Text != "" && ps_Password.Password != "" && ps_Confirm_Password.Password != "" && Compare_password == true)
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection("Data source = admin.db");
                SQLiteCommand sqlite_com = new SQLiteCommand();
                sqlite_conn.Open();
                sqlite_com = sqlite_conn.CreateCommand();

                sqlite_com.CommandText = "SELECT Max(ID) FROM admin_acc";
                int current_ID = Convert.ToInt32(sqlite_com.ExecuteScalar()) + 1;

                sqlite_com.CommandText = "insert into admin_acc(ID, User, Pass, Level) values ('" + current_ID + "', '" + User_name + "', '" + Password + "','" + 0 + "')";
                sqlite_com.ExecuteNonQuery();
                sqlite_conn.Close();

                Tick.Visibility = Visibility.Hidden;

                tb_UserName.Clear();
                ps_Password.Clear();
                ps_Confirm_Password.Clear();

                
                MessageBox.Show("Thêm tài khoản thành công");

                var myObject = this.Owner as Admin_List;
                myObject.Update_DataGrid();
            }

        }

        private void bt_Cancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tb_UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            User_name = tb_UserName.Text;
        }
        private void ps_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = ps_Password.Password;

            if (ps_Confirm_Password.Password == ps_Password.Password && ps_Password.Password != "")
            {
                Tick.Visibility = Visibility.Visible;
                Tick.Source = new BitmapImage(new Uri("/Photo/tick.png", UriKind.Relative));
                Compare_password = true;
            }
            else
                Tick.Source = new BitmapImage(new Uri("/Photo/redx.png", UriKind.Relative));
        }
        private void ps_Confirm_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Confirm_Password = ps_Confirm_Password.Password;

            if (ps_Confirm_Password.Password == ps_Password.Password && ps_Confirm_Password.Password != "")
            {
                Tick.Visibility = Visibility.Visible;
                Tick.Source = new BitmapImage(new Uri("/Photo/tick.png", UriKind.Relative));
                Compare_password = true;
            }
            else
                Tick.Source = new BitmapImage(new Uri("/Photo/redx.png", UriKind.Relative));
        }


        
    }
}
