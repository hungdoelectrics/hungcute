using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2020
{
    public partial class ThongTinSach : Form
    {
        string constr = @"Data Source=DESKTOP-UR3K91K\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";

        private DataTable LayDL(string sql) // hàm lấy ra dữ liệu là bảng, sủ dụng: LayDL(<câu lệnh>)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        private void Lenh(string sql) // Lenh(<câu lệnh>)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cm = new SqlCommand(sql, conn);
            cm.ExecuteNonQuery();
            conn.Close();
        }

        Boolean addnewflag = false;

        public ThongTinSach()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            addnewflag = true;
            txtMaSach.Text = "";
            txtSoLuong.Text = "";
            txtTenSach.Text = "";
            txtNXB.Text = "";
            txtNamXB.Text = "";
            txtNgonNgu.Text = "";
            txtTheLoai.Text = "";
            txtMaTG.Text = "";
            txtMaSach.Focus();//đưa con trỏ soạn thảo về ô mã nhóm
            ////Kiểm tra dữ liệu đầu vào
            //if (txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim() == "" || txtSoLuong.Text.Trim() == "")
            //{
            //    MessageBox.Show("Hãy nhập vào đầy đủ thông tin!", "Thông báo");
            //    return;
            //}
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridThongtinsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ThongTinSach_Load(object sender, EventArgs e)
        {

            string sql = @"SELECT dbo.Sach.MaSach as [Mã Sách], dbo.Sach.TenSach as [Tên Sách], dbo.Sach.NXB as [Nhà Xuất Bản], dbo.Sach.NamXB as [Năm Xuất Bản], dbo.Sach.NgonNgu as [Ngôn Ngữ], dbo.Sach.TenTL as [Thể Loại], dbo.Sach.SoLuong as [Số Lượng],dbo.Sach.MaTG as [Mã Tác Giả]
FROM dbo.Sach";
            DataTable dt = LayDL(sql);
            dataGridThongtinsach.DataSource = dt;
            NapCT();
     
       
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
     

        private void dataGridThongtinsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnThoatLoaiSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuLoaiSach_Click(object sender, EventArgs e)
        {

        }
        public void NapLai()
        {
            string sql = @"SELECT dbo.Sach.MaSach as [Mã Sách], dbo.Sach.TenSach as [Tên Sách], dbo.Sach.NXB as [Nhà Xuất Bản], dbo.Sach.NamXB as [Năm Xuất Bản], dbo.Sach.NgonNgu as [Ngôn Ngữ], dbo.Sach.TenTL as [Thể Loại], dbo.Sach.SoLuong as [Số Lượng],dbo.Sach.MaTG as [Mã Tác Giả] FROM dbo.Sach";
            DataTable dt = LayDL(sql);
            dataGridThongtinsach.DataSource = dt;
            NapCT();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (addnewflag == true)
            {//cập nhật thêm mới
                string sql = "Insert into Sach (MaSach, TenSach, NXB, NamXB, NgonNgu, TenTL, SoLuong, MaTG) Values('" + txtMaSach.Text + "',N'" + txtTenSach.Text
                    + "',N'" + txtNXB.Text + "','" + txtNamXB.Text + "',N'" + txtNgonNgu.Text + "',N'" + txtTheLoai.Text + "','" + txtSoLuong.Text + "','" + txtMaTG.Text + "')";//thêm N để viết tiếng việt
                Lenh(sql);
                addnewflag = false;
                //Nạp lại dữ liệu
                NapLai();

            }
            else//cập nhật sửa đổi
            {
               
                    string tMaSach, tTenSach, tNXB, tNamXB, tNgonNgu, tTheLoai, tSoLuong, tMaTG;
                    int i, n;
                    if (addnewflag == false)
                    {
                        n = Convert.ToInt16(dataGridThongtinsach.RowCount.ToString());
                        for (i = 0; i < n - 1; i++)
                        {
                            tMaSach = dataGridThongtinsach.Rows[i].Cells[0].Value.ToString();
                            tTenSach = dataGridThongtinsach.Rows[i].Cells[1].Value.ToString();
                            tNXB = dataGridThongtinsach.Rows[i].Cells[2].Value.ToString();
                            tNamXB = dataGridThongtinsach.Rows[i].Cells[3].Value.ToString();
                            tNgonNgu = dataGridThongtinsach.Rows[i].Cells[4].Value.ToString();
                            tTheLoai = dataGridThongtinsach.Rows[i].Cells[5].Value.ToString();
                            tSoLuong = dataGridThongtinsach.Rows[i].Cells[6].Value.ToString();
                            tMaTG = dataGridThongtinsach.Rows[i].Cells[7].Value.ToString();
                            string sql = "Update Sach set TenSach = N'" + tTenSach + "',NXB = N'" + tNXB + "',NamXB = '" + tNamXB + "',NgonNgu = N'" + tNgonNgu + "',TenTL = N'" + tTheLoai + "',SoLuong = '" + tSoLuong + "',MaTG = '" + tMaTG + "' where MaSach = '" + tMaSach + "'";
                            Lenh(sql);
                        }

                    }
                    //string sql1 = "Update Sach set TenSach = N'" + txtTenSach.Text + "',NXB = N'" + txtNXB.Text + "',NamXB = '" + txtNamXB.Text + "',NgonNgu = N'" + txtNgonNgu.Text + "',TenTL = N'" + txtTheLoai.Text + "',SoLuong = '" + txtSoLuong.Text + "',MaTG = '" + txtMaTG.Text + "' where MaSach = '" + txtMaSach.Text + "'";
                    //Lenh(sql1);
            
           
                
            }
       
        }
        private void btnXoaLoaiSach_Click(object sender, EventArgs e)
        {
            string MaSach;
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridThongtinsach.CurrentRow.Index.ToString());
                MaSach = dataGridThongtinsach.Rows[i].Cells[0].Value.ToString();
                string sql = "Delete from Sach where MaSach  ='" + MaSach + "'";
                Lenh(sql);
            }
            NapLai();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void NapCT()
        {
            int i = dataGridThongtinsach.CurrentRow.Index;//tao bien i xuat hien o dong dau
            txtMaSach.Text = dataGridThongtinsach[0, i].Value.ToString();//cho ma nhom xuat hien o cot 0
            txtTenSach.Text = dataGridThongtinsach[1, i].Value.ToString();
            txtNXB.Text = dataGridThongtinsach[2, i].Value.ToString();
            txtNamXB.Text = dataGridThongtinsach[3, i].Value.ToString();
            txtNgonNgu.Text = dataGridThongtinsach[4, i].Value.ToString();
            txtTheLoai.Text = dataGridThongtinsach[5, i].Value.ToString();
            txtSoLuong.Text = dataGridThongtinsach[6, i].Value.ToString();
            txtMaTG.Text = dataGridThongtinsach[7, i].Value.ToString();
        }

        private void dataGridThongtinsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
     
    }
}