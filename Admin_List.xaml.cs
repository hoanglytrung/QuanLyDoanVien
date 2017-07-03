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
        int Selected_ID;
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
                tb_Admin_ID.Text = row_selected["ID"].ToString();
                tb_Admin_Name.Text = row_selected["User"].ToString();
                Selected_ID = Int32.Parse(row_selected["ID"].ToString());
                //Admin_Position.Text = row_selected["Chức vụ"].ToString();
            }
        }



        private void Add_admin_Click(object sender, RoutedEventArgs e)
        {
            Create_Admin_Account cre_ad = new Create_Admin_Account();
            cre_ad.Owner = this;
            cre_ad.ShowDialog();
            cre_ad.ShowInTaskbar = false;
            cre_ad.Topmost = true;
        }

        private void Modify_admin_Click(object sender, RoutedEventArgs e)
        {
            tb_Admin_Name.IsEnabled = tb_Admin_Position.IsEnabled = true;
            Modify(Selected_ID);
        }

        private void Modify(int Selected_ID)
        {
            if (tb_Admin_Name.Text != "" && tb_Admin_Position.Text != "")
            {
                //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
                //SQLiteCommand sqlite_com = new SQLiteCommand();
                //sqlite_conn.Open();
                //sqlite_com = sqlite_conn.CreateCommand();
                //sqlite_com.CommandText = "update admin_acc set ";
                //sqlite_com.ExecuteNonQuery();
            }
        }

        private void Delete_admin_Click(object sender, RoutedEventArgs e)
        {
            Delete(Selected_ID); 
        }

        private void Delete(int Selected_ID)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = admin.db");
            SQLiteCommand sqlite_com = new SQLiteCommand();
            sqlite_conn.Open();
            sqlite_com = sqlite_conn.CreateCommand();
            sqlite_com.CommandText = "delete from admin_acc where ID = '" + Selected_ID + "' ";
            sqlite_com.ExecuteNonQuery();

            sqlite_conn.Close();
            Update_DataGrid();
        }
    }
}
