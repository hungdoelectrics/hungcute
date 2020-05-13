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
    public partial class frmLogin : Form
    {
      
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUse.Text == "")
            {
                MessageBox.Show("Please enter user ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUse.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

      
    }
}
