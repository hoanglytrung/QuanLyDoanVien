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
        int Selected_ID;
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
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            sqlite_conn.Open();
            string Query = "select * from DoanVien";
            SQLiteCommand sqlite_com = new SQLiteCommand(Query, sqlite_conn);
            sqlite_com.ExecuteNonQuery();

            SQLiteDataAdapter sqlite_adp = new SQLiteDataAdapter(sqlite_com);
            DataTable dt = new DataTable("DoanVien");
            sqlite_adp.Fill(dt);
            dg_DoanVien.ItemsSource = dt.DefaultView;
            sqlite_adp.Update(dt);
            sqlite_conn.Close();
        }

        private void dg_DoanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg1 = (DataGrid)sender;
            DataRowView row_selected = dg1.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                MaDoanVien.Text = row_selected["ID"].ToString();
                HoVaTen.Text = row_selected["Hoten"].ToString();
                NgaySinh.Text = row_selected["Ngaysinh"].ToString();
                QueQuan.Text = row_selected["Quequan"].ToString();
                GioiTinh.Text = row_selected["Gioitinh"].ToString();
                ChiDoan.Text = row_selected["Chidoan"].ToString();
                ChucVu.Text = row_selected["Chucvu"].ToString();
                ToDanPho.Text = row_selected["Todanpho"].ToString();
                PhuongXa.Text = row_selected["Phuong_Xa"].ToString();
                QuanHuyen.Text = row_selected["Quan_Huyen"].ToString();
                TinhThanh.Text = row_selected["Tinh_Thanh"].ToString();
                NgayVaoDoan.Text = row_selected["Ngayvaodoan"].ToString();
                NgayVaoDang.Text = row_selected["Ngayvaodang"].ToString();
                TinhTrang.Text = row_selected["Tinhtrang"].ToString();
                CMND.Text = row_selected["CMND"].ToString();
                Email.Text = row_selected["Email"].ToString();
                DienThoai.Text = row_selected["Dienthoai"].ToString();
                DanToc.Text = row_selected["Dantoc"].ToString();
                TonGiao.Text = row_selected["Tongiao"].ToString();
                HoanCanh.Text = row_selected["Hoancanh"].ToString();
                TrinhDo.Text = row_selected["Trinhdo"].ToString();

                Selected_ID = Int32.Parse(MaDoanVien.Text);
            }
        }

        bool Add = false;
        private void Add_DoanVien_Click(object sender, RoutedEventArgs e)
        {
            Add = true;

            Add_DoanVien.IsEnabled = false;
            Mod_DoanVien.IsEnabled = false;

            SQLiteConnection sqlite_conn = new SQLiteConnection("Data source = QuanLyDoanVien.db");
            SQLiteCommand sqlite_com = new SQLiteCommand();
            sqlite_conn.Open();
            sqlite_com = sqlite_conn.CreateCommand();

            sqlite_com.CommandText = "SELECT Max(ID) FROM DoanVien";
            MaDoanVien.Text = (Convert.ToInt32(sqlite_com.ExecuteScalar()) + 1).ToString();

         

            HoVaTen.IsEnabled = NgaySinh.IsEnabled = QueQuan.IsEnabled = 
            GioiTinh.IsEnabled = ChiDoan.IsEnabled = ChucVu.IsEnabled = ToDanPho.IsEnabled =
            PhuongXa.IsEnabled = QuanHuyen.IsEnabled = TinhThanh.IsEnabled = NgayVaoDang.IsEnabled = 
            NgayVaoDoan.IsEnabled = TinhTrang.IsEnabled = CMND.IsEnabled = Email.IsEnabled = 
            DienThoai.IsEnabled = DanToc.IsEnabled = TonGiao.IsEnabled = HoanCanh.IsEnabled = TrinhDo.IsEnabled 
            = true;

            HoVaTen.Clear();
            NgaySinh.Clear(); QueQuan.Clear();
            GioiTinh.Clear(); ChiDoan.Clear(); ChucVu.Clear(); ToDanPho.Clear();
            PhuongXa.Clear(); QuanHuyen.Clear(); TinhThanh.Clear(); NgayVaoDang.Clear();
            NgayVaoDoan.Clear(); TinhTrang.Clear(); CMND.Clear(); Email.Clear();
            DienThoai.Clear(); DanToc.Clear(); TonGiao.Clear(); HoanCanh.Clear(); TrinhDo.Clear();


        }
        public void Update_DataGrid()
        {
            //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            //DataSet dataSet = new DataSet();
            //SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * From admin_acc", sqlite_conn);
            //dataAdapter.Fill(dataSet);
            //DataTable dt = new DataTable("admin_acc");
            ////DtGrid.ItemsSource = dataSet.Tables[0].DefaultView;
            //DtGrid.ItemsSource = dt.DefaultView;
            //dataAdapter.Update(dt);

            //sqlite_conn.Close();

            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            sqlite_conn.Open();
            string Query = "select * from DoanVien";
            SQLiteCommand sqlite_com = new SQLiteCommand(Query, sqlite_conn);
            sqlite_com.ExecuteNonQuery();

            SQLiteDataAdapter sqlite_adp = new SQLiteDataAdapter(sqlite_com);
            DataTable dt = new DataTable("DoanVien");
            sqlite_adp.Fill(dt);
            dg_DoanVien.ItemsSource = dt.DefaultView;
            sqlite_adp.Update(dt);
            sqlite_conn.Close();
        }

        bool Mod = false;
        private void Mod_DoanVien_Click(object sender, RoutedEventArgs e)
        {
            Add_DoanVien.IsEnabled = false;
            Mod_DoanVien.IsEnabled = false;
            MaDoanVien.IsEnabled = HoVaTen.IsEnabled = NgaySinh.IsEnabled = QueQuan.IsEnabled =
            GioiTinh.IsEnabled = ChiDoan.IsEnabled = ChucVu.IsEnabled = ToDanPho.IsEnabled =
            PhuongXa.IsEnabled = QuanHuyen.IsEnabled = TinhThanh.IsEnabled = NgayVaoDang.IsEnabled =
            NgayVaoDoan.IsEnabled = TinhTrang.IsEnabled = CMND.IsEnabled = Email.IsEnabled =
            DienThoai.IsEnabled = DanToc.IsEnabled = TonGiao.IsEnabled = HoanCanh.IsEnabled = TrinhDo.IsEnabled
            = true;

            Mod = true;
        }

        private void Del_DoanVien_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            SQLiteCommand sqlite_com = new SQLiteCommand();
            sqlite_conn.Open();
            sqlite_com = sqlite_conn.CreateCommand();
            sqlite_com.CommandText = "delete from DoanVien where ID = '" + Selected_ID + "' ";
            sqlite_com.ExecuteNonQuery();

            sqlite_conn.Close();
            Update_DataGrid();
        }

        private void Update_row(string row, string text)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            SQLiteCommand sqlite_com = new SQLiteCommand();
            sqlite_conn.Open();
            sqlite_com = sqlite_conn.CreateCommand();
            sqlite_com.CommandText = "Update DoanVien " + "set '" + row + "' = '" + text + "' ";
            sqlite_com.ExecuteNonQuery();

            sqlite_conn.Close();
            Update_DataGrid();

        }
        private void Insert_row(string col, string value)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
            SQLiteCommand sqlite_com = new SQLiteCommand();
            sqlite_conn.Open();
            sqlite_com = sqlite_conn.CreateCommand();
            sqlite_com.CommandText = "insert into DoanVien( '" + col +"' ) values ( '"+ value +"' )";
            sqlite_com.ExecuteNonQuery();

            sqlite_conn.Close();
            Update_DataGrid();

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Add == true)
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = QuanLyDoanVien.db");
                SQLiteCommand sqlite_com = new SQLiteCommand();
                sqlite_conn.Open();
                sqlite_com = sqlite_conn.CreateCommand();
                sqlite_com.CommandText = "insert into DoanVien values ( '" + MaDoanVien.Text + "', '" + HoVaTen.Text + "', " +
                                                                        "'" + NgaySinh.Text + "', '" + QueQuan.Text + "',  '" + GioiTinh.Text + "', '" + ChiDoan.Text + "', " +
                                                                        "'" + ChucVu.Text + "', '" + ToDanPho.Text + "', '" + PhuongXa.Text + "', '" + QuanHuyen.Text + "', " +
                                                                        "'" + TinhThanh.Text + "', '" + NgayVaoDoan.Text + "',  '" + NgayVaoDang.Text + "', '" + TinhTrang.Text + "', " +
                                                                        "'" + CMND.Text + "', '" + Email.Text + "', '" + DienThoai.Text + "', '" + DanToc.Text + "', " +
                                                                        "'" + TonGiao.Text + "', '" + HoanCanh.Text + "', '" + TrinhDo.Text + "')";
                sqlite_com.ExecuteNonQuery();

                sqlite_conn.Close();
                Update_DataGrid();

                Add_DoanVien.IsEnabled = true;
                Mod_DoanVien.IsEnabled = true;
            }

            if (Mod == true)
            {
                Update_row("Hoten", HoVaTen.Text);
                Update_row("Ngaysinh", NgaySinh.Text);
                Update_row("Quequan", QueQuan.Text);
                Update_row("Gioitinh", GioiTinh.Text);
                Update_row("Chidoan", ChiDoan.Text);
                Update_row("Chucvu", ChucVu.Text);
                Update_row("Todanpho", ToDanPho.Text);
                Update_row("Phuong_Xa", PhuongXa.Text);
                Update_row("Quan_Huyen", QuanHuyen.Text);
                Update_row("Tinh_Thanh", TinhThanh.Text);
                Update_row("Ngayvaodoan", NgayVaoDoan.Text);
                Update_row("Ngayvaodang", NgayVaoDang.Text);
                Update_row("Tinhtrang", TinhTrang.Text);
                Update_row("CMND", CMND.Text);
                Update_row("Email", Email.Text);
                Update_row("Dienthoai", DienThoai.Text);
                Update_row("Dantoc", DanToc.Text);
                Update_row("Tongiao", TonGiao.Text);
                Update_row("Hoancanh", HoanCanh.Text);
                Update_row("Trinhdo", TrinhDo.Text);

                MaDoanVien.IsEnabled = HoVaTen.IsEnabled = NgaySinh.IsEnabled = QueQuan.IsEnabled =
               GioiTinh.IsEnabled = ChiDoan.IsEnabled = ChucVu.IsEnabled = ToDanPho.IsEnabled =
               PhuongXa.IsEnabled = QuanHuyen.IsEnabled = TinhThanh.IsEnabled = NgayVaoDang.IsEnabled =
               NgayVaoDoan.IsEnabled = TinhTrang.IsEnabled = CMND.IsEnabled = Email.IsEnabled =
               DienThoai.IsEnabled = DanToc.IsEnabled = TonGiao.IsEnabled = HoanCanh.IsEnabled = TrinhDo.IsEnabled
               = false;
                Mod = false;

                Add_DoanVien.IsEnabled = true;
                Mod_DoanVien.IsEnabled = true;
            }
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            Add_DoanVien.IsEnabled = true;
            Mod_DoanVien.IsEnabled = true;

            MaDoanVien.IsEnabled = HoVaTen.IsEnabled = NgaySinh.IsEnabled = QueQuan.IsEnabled =
            GioiTinh.IsEnabled = ChiDoan.IsEnabled = ChucVu.IsEnabled = ToDanPho.IsEnabled =
            PhuongXa.IsEnabled = QuanHuyen.IsEnabled = TinhThanh.IsEnabled = NgayVaoDang.IsEnabled =
            NgayVaoDoan.IsEnabled = TinhTrang.IsEnabled = CMND.IsEnabled = Email.IsEnabled =
            DienThoai.IsEnabled = DanToc.IsEnabled = TonGiao.IsEnabled = HoanCanh.IsEnabled = TrinhDo.IsEnabled
            = false;
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
