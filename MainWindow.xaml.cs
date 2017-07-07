using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
using Wpf.Controls;
using System.Diagnostics;
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
            //MessageBox.Show("Create");
            Admin_List ad_list = new Admin_List(current_acc)
            {
                ShowInTaskbar = false
            };
            ad_list.Update_DataGrid();
            ad_list.ShowDialog();
            ad_list.Topmost = true;
        }

        private void Change_Password_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Đổi pass");
            Change_Pass cp = new Change_Pass(current_acc);
            cp.ShowDialog();
            
        }

        private void Doan_Vien_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
            sqlite_conn.Open();
            string Query = "select ID, User, Level from admin_acc";
            SQLiteCommand sqlite_com = new SQLiteCommand(Query, sqlite_conn);
            sqlite_com.ExecuteNonQuery();

            SQLiteDataAdapter sqlite_adp = new SQLiteDataAdapter(sqlite_com);
            DataTable dt = new DataTable("admin_acc");
            sqlite_adp.Fill(dt);
            dg_DoanVien.ItemsSource = dt.DefaultView;
            sqlite_adp.Update(dt);
            sqlite_conn.Close();
        }

        //private int count = 1;
        //void tabControl_TabItemAdded(object sender, TabItemEventArgs e)
        //{
        //    // Add an Icon to the tabItem
        //    BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/Test;component/Images/ie.ico"));
        //    Image img = new Image();
        //    img.Source = image;
        //    img.Width = 16;
        //    img.Height = 16;
        //    img.Margin = new Thickness(2, 0, 2, 0);

        //    e.TabItem.Icon = img;

        //    // wrap the header in a textblock, this gives us the  character ellipsis (...) when trimmed
        //    TextBlock tb = new TextBlock();
        //    tb.Text = "New Tab " + count++;
        //    tb.TextTrimming = TextTrimming.CharacterEllipsis;
        //    tb.TextWrapping = TextWrapping.NoWrap;

        //    e.TabItem.Header = tb;

        //    // add a WebControl to the TAbItem
        //    WindowsFormsHost host = new WindowsFormsHost();
        //    host.Margin = new Thickness(2);
        //    System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();
        //    browser.DocumentTitleChanged += Browser_DocumentTitleChanged;
        //    browser.Navigated += Browser_Navigated;

        //    host.Child = browser;
        //    e.TabItem.Content = host;
        //}

    }
}
