using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTV2020
{
    public partial class QuanLyTraSach : Form
    {
        SqlConnection conn = new SqlConnection();//tạo kết nối
        string ketnoi = @"Data Source=DESKTOP-UR3K91K\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string SQL;

        public QuanLyTraSach()
        {
            InitializeComponent();
        }

        private void lvwDanhSachTra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyTraSach_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketnoi);
            SQL = @"SELECT dbo.Sach.MaSach, dbo.Sach.SoLuong,dbo.Sach.NamXB,dbo.Sach.NXB,dbo.Sach.NgonNgu,dbo.TheLoai.TenTL,dbo.Sach.TenSach,dbo.TacGia.TenTG
FROM dbo.Sach,dbo.TheLoai,dbo.TacGia";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridDanhSachTra.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
    }
}
