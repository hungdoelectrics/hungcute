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
    public partial class QuanLyMuonSach : Form
    {
        SqlConnection conn = new SqlConnection();//tạo kết nối
        string ketnoi = @"Data Source=DESKTOP-UR3K91K\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string SQL;
        public QuanLyMuonSach()
        {
            InitializeComponent();
        }

        private void QuanLyMuonSach_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketnoi);
            SQL = @"SELECT dbo.PhieuMuon.MaDG as [Mã Độc Giả],dbo.ChiTietPM.MaSach as [Mã Sách],dbo.ChiTietPM.SoLuong as [Số Lượng Mượn],dbo.PhieuMuon.NgayThue as [Ngày Thuê Sách],dbo.PhieuMuon.NgayTra as [Ngày Trả Sách]
FROM dbo.PhieuMuon,dbo.ChiTietPM
WHERE dbo.PhieuMuon.MaPM = dbo.ChiTietPM.MaPM";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            da.Fill(dt);
            datagridQLMS.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnMuonMoi_Click(object sender, EventArgs e)
        {

        }

        private void cbChonMaSach_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dtNgayMuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lvwDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void datagridQLMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
