//
// frmLogin
//	
// Form đăng nhập
// 
// Tác giả: Nguyên Khôi
//

using DoAn.BUS;
using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //
        // Phương thức event khi nhấn Đăng nhập
        //
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string chucVu = new TaiKhoanBUS().CheckLogin(txtTenDN.Text, txtPass.Text);
                if (chucVu=="Quản lí")
                {
                    this.Hide();
                    frmManager fma = new frmManager
                    {
                        _tenDN = this.txtTenDN.Text,
                        _pass = this.txtPass.Text
                    };
                    fma.ShowDialog();
                    this.Show();
                }

                if (chucVu == "Nhân viên")
                {
                    this.Hide();
                    frmEmployee fme = new frmEmployee();
                    frmEmployee._tenDN = txtTenDN.Text;
                    frmEmployee._pass = txtPass.Text;
                    fme.ShowDialog();
                    this.Show();
                }

                if (chucVu == "Thủ kho")
                {
                    this.Hide();
                    FrmStockKeeper fnk = new FrmStockKeeper();
                    FrmStockKeeper._tenDN = txtTenDN.Text;
                    FrmStockKeeper._pass = txtPass.Text;
                    fnk.ShowDialog();
                    this.Show();
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }

        //
        // Phương thức event khi nhấn Thoát
        //
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
