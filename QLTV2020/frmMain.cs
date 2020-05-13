using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV2020
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSach f = new ThongTinSach();
            f.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia f = new QuanLyDocGia();
            f.ShowDialog();
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMuonSach f = new QuanLyMuonSach();
            f.ShowDialog();

        }

        private void quảnLýTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTraSach f = new QuanLyTraSach();
            f.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Close();

        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia f = new TacGia();
            f.ShowDialog();
        }

        private void tìmKiếmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
