//
// frmServer
//	
// Form cấu hình server
// 
// Tác giả: Nguyên Khôi
//

using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmServer : Form
    {
        public string conStr;
        public frmServer()
        {
            InitializeComponent();
        }

        //
        // Phương thức event form load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtUser.Enabled = false;
            txtPass.Enabled = false;  
        }

        //
        // Phương thức event khi nhấn Exit
        //
        private void BtnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        //
        // Phương thức event khi nhấn radio button Sql server authentication
        //
        private void RboSv2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoSv2.Checked)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
            }
        }

        //
        // Phương thức event khi nhấn Kết nối
        //
        private void BtnConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoSv1.Checked)
                    conStr = string.Format("Data Source ={0}; Initial Catalog = {1}; Integrated Security = True",txtServerName.Text, txtDataName.Text);
                if (rdoSv2.Checked)
                    conStr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",txtServerName.Text, txtDataName.Text, txtUser.Text, txtPass.Text);

                SqlHelper helper = new SqlHelper(conStr);
                if (helper.IsConnection)
                {
                    MessageBox.Show("Kết nối thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DAO.DataProvider._constr = conStr;
                FrmLogin fm = new FrmLogin();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            catch 
            {
                MessageBox.Show("Kết nối thất bại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
