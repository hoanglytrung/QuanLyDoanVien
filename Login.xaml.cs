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

namespace QuanLyDoanVien
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            if (tb_username.Text == "hoanglytrung" && ps_password.Password.ToString() == "1")
            {
                this.Hide();
                MainWindow ss = new MainWindow();
                ss.Show();
                this.Close();
            }
            else if (tb_username.Text == "" && ps_password.Password.ToString() == "")
            {
                MessageBox.Show("Nhập Username và Password");
            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng");
            }
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
