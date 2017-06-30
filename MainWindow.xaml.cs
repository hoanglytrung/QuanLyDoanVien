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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyDoanVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Account current_acc = new Account();
        public MainWindow(Account acc)
        {
            current_acc = acc;
            InitializeComponent();
        }
        private void Create_Admin_Account_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Create");

        }

        private void Change_Password_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Đổi pass");
            Change_Pass cp = new Change_Pass(current_acc);
            cp.ShowDialog();
            
        }
    }
}
