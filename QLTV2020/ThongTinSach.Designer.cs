namespace QLTV2020
{
    partial class ThongTinSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridThongtinsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radTensach = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radMasach = new System.Windows.Forms.RadioButton();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMasach = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemLoaiSach = new System.Windows.Forms.Button();
            this.btnThoatLoaiSach = new System.Windows.Forms.Button();
            this.btnXoaLoaiSach = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongtinsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridThongtinsach);
            this.groupBox1.Location = new System.Drawing.Point(409, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 550);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridThongtinsach
            // 
            this.dataGridThongtinsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThongtinsach.Location = new System.Drawing.Point(0, 22);
            this.dataGridThongtinsach.Name = "dataGridThongtinsach";
            this.dataGridThongtinsach.RowTemplate.Height = 28;
            this.dataGridThongtinsach.Size = new System.Drawing.Size(708, 522);
            this.dataGridThongtinsach.TabIndex = 0;
            this.dataGridThongtinsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridThongtinsach_CellClick);
            this.dataGridThongtinsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridThongtinsach_CellContentClick);
            this.dataGridThongtinsach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridThongtinsach_CellValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaTG);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtNgonNgu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNamXB);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtTheLoai);
            this.groupBox2.Controls.Add(this.txtNXB);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblMasach);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 550);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(144, 390);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(230, 26);
            this.txtMaTG.TabIndex = 11;
            this.txtMaTG.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(144, 340);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(230, 26);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(144, 230);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(230, 26);
            this.txtNgonNgu.TabIndex = 12;
            this.txtNgonNgu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngôn Ngữ";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(144, 181);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(230, 26);
            this.txtNamXB.TabIndex = 10;
            this.txtNamXB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.radTensach);
            this.groupBox4.Controls.Add(this.btnTimkiem);
            this.groupBox4.Controls.Add(this.radMasach);
            this.groupBox4.Location = new System.Drawing.Point(6, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 115);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 39);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radTensach
            // 
            this.radTensach.AutoSize = true;
            this.radTensach.BackColor = System.Drawing.Color.Transparent;
            this.radTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTensach.ForeColor = System.Drawing.Color.Black;
            this.radTensach.Location = new System.Drawing.Point(112, 89);
            this.radTensach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTensach.Name = "radTensach";
            this.radTensach.Size = new System.Drawing.Size(102, 24);
            this.radTensach.TabIndex = 5;
            this.radTensach.TabStop = true;
            this.radTensach.Text = "Tên Sách";
            this.radTensach.UseVisualStyleBackColor = false;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(242, 50);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 59);
            this.btnTimkiem.TabIndex = 16;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radMasach
            // 
            this.radMasach.AutoSize = true;
            this.radMasach.BackColor = System.Drawing.Color.Transparent;
            this.radMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMasach.ForeColor = System.Drawing.Color.Black;
            this.radMasach.Location = new System.Drawing.Point(7, 89);
            this.radMasach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMasach.Name = "radMasach";
            this.radMasach.Size = new System.Drawing.Size(97, 24);
            this.radMasach.TabIndex = 4;
            this.radMasach.TabStop = true;
            this.radMasach.Text = "Mã Sách";
            this.radMasach.UseVisualStyleBackColor = false;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(144, 281);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(230, 26);
            this.txtTheLoai.TabIndex = 13;
            this.txtTheLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(144, 125);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(230, 26);
            this.txtNXB.TabIndex = 11;
            this.txtNXB.TextChanged += new System.EventHandler(this.txtNXB_TextChanged);
            this.txtNXB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(144, 77);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(230, 26);
            this.txtTenSach.TabIndex = 14;
            this.txtTenSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(144, 25);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(230, 26);
            this.txtMaSach.TabIndex = 8;
            this.txtMaSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Location = new System.Drawing.Point(19, 31);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(69, 20);
            this.lblMasach.TabIndex = 0;
            this.lblMasach.Text = "Mã sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemLoaiSach);
            this.groupBox3.Controls.Add(this.btnThoatLoaiSach);
            this.groupBox3.Controls.Add(this.btnXoaLoaiSach);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1101, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoaiSach.Location = new System.Drawing.Point(91, 17);
            this.btnThemLoaiSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.Size = new System.Drawing.Size(100, 40);
            this.btnThemLoaiSach.TabIndex = 6;
            this.btnThemLoaiSach.Text = "Thêm Mới";
            this.btnThemLoaiSach.UseVisualStyleBackColor = true;
            this.btnThemLoaiSach.Click += new System.EventHandler(this.btnThemLoaiSach_Click);
            // 
            // btnThoatLoaiSach
            // 
            this.btnThoatLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLoaiSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatLoaiSach.Location = new System.Drawing.Point(482, 17);
            this.btnThoatLoaiSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoatLoaiSach.Name = "btnThoatLoaiSach";
            this.btnThoatLoaiSach.Size = new System.Drawing.Size(100, 40);
            this.btnThoatLoaiSach.TabIndex = 10;
            this.btnThoatLoaiSach.Text = "Thoát";
            this.btnThoatLoaiSach.UseVisualStyleBackColor = true;
            this.btnThoatLoaiSach.Click += new System.EventHandler(this.btnThoatLoaiSach_Click);
            // 
            // btnXoaLoaiSach
            // 
            this.btnXoaLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLoaiSach.Location = new System.Drawing.Point(351, 17);
            this.btnXoaLoaiSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaLoaiSach.Name = "btnXoaLoaiSach";
            this.btnXoaLoaiSach.Size = new System.Drawing.Size(100, 40);
            this.btnXoaLoaiSach.TabIndex = 9;
            this.btnXoaLoaiSach.Text = "Xóa";
            this.btnXoaLoaiSach.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSach.Click += new System.EventHandler(this.btnXoaLoaiSach_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(221, 17);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 40);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(528, 40);
            this.label8.TabIndex = 4;
            this.label8.Text = "DANH MỤC THÔNG TIN SÁCH";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 699);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ThongTinSach";
            this.Text = "Quản lý thông tin sách";
            this.Load += new System.EventHandler(this.ThongTinSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongtinsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridThongtinsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radTensach;
        private System.Windows.Forms.RadioButton radMasach;
        private System.Windows.Forms.Button btnThemLoaiSach;
        private System.Windows.Forms.Button btnThoatLoaiSach;
        private System.Windows.Forms.Button btnXoaLoaiSach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTG;

    }
}