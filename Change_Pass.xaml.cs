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
    /// Interaction logic for Change_Pass.xaml
    /// </summary>
    public partial class Change_Pass : Window
    {
        public Change_Pass()
        {
            InitializeComponent();
        }
        
        Account current_acc = new Account();
        private bool Compare_password = false;

        public Change_Pass(Account acc)
        {
            current_acc = acc;
            InitializeComponent();
        }
        
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(current_acc.User);
            if (ps_CurrentPass.Password == current_acc.Pass )
            {
                if (Compare_password == true)
                {
                    SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
                    SQLiteCommand sqlite_cmd;
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "Update admin_acc Set Pass = '" + ps_NewPass.Password + "' where ID = '" + current_acc.ID + "' ;";
                    sqlite_cmd.ExecuteScalar(); 
                    MessageBox.Show("Đổi mật khẩu thành công");
                    sqlite_conn.Close();
                    current_acc.Update_Password();
                    //MessageBox.Show(current_acc.Pass);
                    this.Close();
                }
            }
            else
            {
                Wrong_Current_Password.Visibility = Visibility.Visible;
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void ps_ConfirmNewPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ps_ConfirmNewPass.Password == ps_NewPass.Password)
            {
                Tick.Source = new BitmapImage(new Uri("/Photo/tick.png", UriKind.Relative));
                Compare_password = true;
            }
            else
            {
                Tick.Source = new BitmapImage(new Uri("/Photo/redx.png", UriKind.Relative));
            }
        }

        private void ps_CurrentPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Wrong_Current_Password.Visibility = Visibility.Hidden;
        }

        
    }
}
