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
    public partial class TacGia : Form
    {
        SqlConnection conn = new SqlConnection();//tạo kết nối
        string ketnoi = @"Data Source=DESKTOP-UR3K91K\SQLEXPRESS;Initial Catalog=final;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string SQL;
    public TacGia()
        {
            InitializeComponent();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketnoi);
            SQL = "SELECT dbo.TacGia.MaTG,dbo.TacGia.TenTG, dbo.TacGia.NamSinh, dbo.TacGia.GioiTinh FROM dbo.TacGia";
            da = new SqlDataAdapter(SQL, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridDanhSachTG.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }


        private void txtMaTG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
