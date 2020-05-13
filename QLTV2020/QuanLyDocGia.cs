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
    public partial class QuanLyDocGia : Form
    {
        SqlConnection con;
        SqlDataAdapter daDocGia;
        DataSet ds;

        public QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datetimeNS_ValueChanged(object sender, EventArgs e)
        {



        }

        private void datetimeNHH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datetimeNT_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            string sChuoiKetNoi = @"Data Source=DESKTOP-UR3K91K\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            string sSelectDocGia = @"Select * From DocGia";
    
            SqlConnection con = new SqlConnection();
            con.ConnectionString = sChuoiKetNoi;
            //Kiểm tra xem chúng ta có đang mở kết nối không
            if (con.State == ConnectionState.Closed)
            {
                //Mở kết nối
                con.Open();
            }

            daDocGia = new SqlDataAdapter(sSelectDocGia, con);
            ds = new DataSet();
            daDocGia.Fill(ds, "DocGia");
           datagridTheThuVien.DataSource = ds.Tables["DocGia"];
            //// Thêm dữ liệu vào database thông qua dataset và đối tượng DataAdapter
            //Tạo câu lệnh Insert
            string sInsertCommand = @"Insert into DocGia(MaDG,TenDG,NamSinh,DiaChi,SDT,NgayCapThe,NgayHetHan,GioiTinh,NgheNghiep) values(@MaDG,@TenDG,@NamSinh,@DiaChi,@SDT,@NgayCapThe,@NgayHetHan,@GioiTinh,@NgheNghiep)";
            //Tạo đối tượng command chứa các parameter tương ứng với thuộc tính của database 
            SqlCommand cmdInsert = new SqlCommand(sInsertCommand, con);
            cmdInsert.Parameters.Add("@MaDG", SqlDbType.NChar, 50, "MaDG");
            cmdInsert.Parameters.Add("@GioiTinh", SqlDbType.Bit, 2, "GioiTinh");
            cmdInsert.Parameters.Add("@NamSinh", SqlDbType.DateTime, 10, "NamSinh");
            cmdInsert.Parameters.Add("@NgayCapThe", SqlDbType.DateTime, 10, "NgayCapThe");
            cmdInsert.Parameters.Add("@NgayHetHan", SqlDbType.DateTime, 10, "NgayHetHan");
            cmdInsert.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 250, "DiaChi");
            cmdInsert.Parameters.Add("@NgheNghiep", SqlDbType.NVarChar, 25, "NgheNghiep");
            cmdInsert.Parameters.Add("@SDT", SqlDbType.NChar, 20, "SDT");
            cmdInsert.Parameters.Add("@TenDG", SqlDbType.NVarChar, 25, "TenDG");
            //Gán thuộc tính insertcommand của DataAdapter = đối tượng command vừa tạo
            daDocGia.InsertCommand = cmdInsert;

            //tạo câu lệnh update
           // string sUpdatecommand = @"Update DocGia set TenDG = @TenDG, GioiTinh=@GioiTinh,NamSinh=@NamSinh,DiaChi=@DiaChi,SDT=@SDT,NgayCapThe = @NgayCapThe, NgayHetHan = @NgayHetHan, NgheNghiep = @NgheNghiep where MaDG = @MaDG"; "

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        
            //Kiểm tra dữ liệu đầu vào
            if (txtmathe.Text.Trim() == "" || txttenthe.Text.Trim() == "" || txtdt.Text.Trim() == "" ||txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào đầy đủ thông tin!", "Thông báo");
                return;
            }
            //Thêm 1 dòng trong datatable chưa trong dataset
            DataRow r = ds.Tables["Docgia"].NewRow();
            r["MaDG"] = txtmathe.Text;
            r["TenDG"] = txttenthe.Text;
            r["NgheNghiep"] = txtNgheNghiep.Text;
            r["DiaChi"] = txtdiachi.Text;
            r["SDT"] = txtdt.Text;
            r["NamSinh"] = dtpNS.Value;
            r["NgayCapThe"] = dtpNgayTao.Value;
            r["NgayHetHan"] = dtpNgayHH.Value;
            //if (cmbsex.ValueMember == "Nữ")//Giới tính chưa giải đc, làm cái gì nó cũng ra false
            //{
            //    r["GioiTinh"] = true;
            //}
            //else
            //{
            //    r["GioiTinh"] = false;
            //}
        
          
            //Thêm 1 dòng vào table tblNhanVien trên dataSet
            ds.Tables["DocGia"].Rows.Add(r);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            daDocGia.Update(ds, "DocGia");
            MessageBox.Show("Lưu thành công !", "Thông báo");
     
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        
        }
        
    }
}
