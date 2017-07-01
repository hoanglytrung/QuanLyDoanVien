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
using System.Data;

namespace QuanLyDoanVien
{
    /// <summary>
    /// Interaction logic for Admin_List.xaml
    /// </summary>
    public partial class Admin_List : Window
    {
        public Admin_List()
        {
            InitializeComponent();
        }
        public Account current_acc = new Account();

        public Admin_List(Account acc)
        {
            InitializeComponent();

            current_acc = acc;
            if (current_acc.Level == 1)
            {
                Add_admin.IsEnabled = true;
                Modify_admin.IsEnabled = true;
                Delete_admin.IsEnabled = true;
            }
        }
        public void Update_DataGrid()
        {
            //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
            //DataSet dataSet = new DataSet();
            //SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * From admin_acc", sqlite_conn);
            //dataAdapter.Fill(dataSet);
            //DataTable dt = new DataTable("admin_acc");
            ////DtGrid.ItemsSource = dataSet.Tables[0].DefaultView;
            //DtGrid.ItemsSource = dt.DefaultView;
            //dataAdapter.Update(dt);

            //sqlite_conn.Close();

            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
            sqlite_conn.Open();
            string Query = "select ID, User, Level from admin_acc";
            SQLiteCommand sqlite_com = new SQLiteCommand(Query, sqlite_conn);
            sqlite_com.ExecuteNonQuery();

            SQLiteDataAdapter sqlite_adp = new SQLiteDataAdapter(sqlite_com);
            DataTable dt = new DataTable("admin_acc");
            sqlite_adp.Fill(dt);
            Admin_DataGrid.ItemsSource = dt.DefaultView;
            sqlite_adp.Update(dt);
            sqlite_conn.Close();
        }

        public void Get_Item()
        {
            DataRowView drv = (DataRowView)Admin_DataGrid.SelectedItem;
            String result = (drv["ID"]).ToString();
            MessageBox.Show(result);
        }

        private void Admin_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView row_selected = dg.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                Admin_ID.Text = row_selected["ID"].ToString();
                Admin_Name.Text = row_selected["User"].ToString();
                //Admin_Position.Text = row_selected["Chức vụ"].ToString();
            }
        }

        private void Add_admin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Modify_admin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_admin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
