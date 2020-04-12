//
// frmStockKeeper
//	
// Form dành cho thủ kho
// 
// Tác giả: Nguyên Khôi
//

using DoAn.BUS;
using DoAn.DTO;
using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmStockKeeper : Form
    {
        public static string _tenDN;
        public static string _pass;

        public FrmStockKeeper()
        {
            InitializeComponent();
        }

        //
        // Phương thức event form load
        //
        private void FNhapKho_Load(object sender, EventArgs e)
        {
            gridData0.DataSource = new TaiKhoanBUS().LoadAcc(_tenDN, _pass);
            txtID0.Text = gridData0.Rows[0].Cells[0].Value.ToString();
            gridData3.DataSource = new SanPhamBUS().LoadAccSP();

            txtHoTen0.Text = gridData0.Rows[0].Cells[1].Value.ToString();
            txtTenDN0.Text = gridData0.Rows[0].Cells[2].Value.ToString();
            txtOldPass0.Text = gridData0.Rows[0].Cells[3].Value.ToString();
            txtChucVu0.Text = gridData0.Rows[0].Cells[4].Value.ToString();
            txtDC0.Text = gridData0.Rows[0].Cells[5].Value.ToString();
            txtSDT0.Text = gridData0.Rows[0].Cells[6].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Cập nhật ở tab thông tin cá nhân
        //
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtID0.Text) && !string.IsNullOrWhiteSpace(txtHoTen0.Text) && !string.IsNullOrWhiteSpace(txtTenDN0.Text)
                && !string.IsNullOrWhiteSpace(txtNewPass0.Text) && !string.IsNullOrWhiteSpace(txtDC0.Text) && !string.IsNullOrWhiteSpace(txtSDT0.Text))
                {
                    TaiKhoan newData = new TaiKhoan(Convert.ToInt32(txtID0.Text), txtHoTen0.Text, txtTenDN0.Text, txtNewPass0.Text,
                txtChucVu0.Text, txtDC0.Text, txtSDT0.Text);
                    new TaiKhoanBUS().Update(newData);
                    gridData0.DataSource = null;
                    gridData0.DataSource = new TaiKhoanBUS().LoadAcc(txtTenDN0.Text, txtNewPass0.Text);
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtOldPass0.Text = txtNewPass0.Text;
            txtNewPass0.Text = "";
        }

        //
        // Phương thức event khi nhấn đăng xuất
        //
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // Phương thức event khi nhấn vào 1 dòng data grid view ở tab sản phẩm
        //
        private void GridData3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;//lấy index của dòng đang chọn trên bảng
            txtTenSP3.Text = gridData3.Rows[numRow].Cells[1].Value.ToString();
            txtDGN3.Text = gridData3.Rows[numRow].Cells[2].Value.ToString();
            txtDGB3.Text = gridData3.Rows[numRow].Cells[3].Value.ToString();
            txtSoL3.Text = gridData3.Rows[numRow].Cells[4].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Thêm ở tab sản phẩm
        //
        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData3.Rows[gridData3.RowCount - 1].Cells[0].Value.ToString());
            new SanPhamBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenSP3.Text) && !string.IsNullOrWhiteSpace(txtDGN3.Text)
                    && !string.IsNullOrWhiteSpace(txtDGB3.Text) && !string.IsNullOrWhiteSpace(txtSoL3.Text))
                {
                    SanPham newData = new SanPham(0, txtTenSP3.Text, Convert.ToInt32(txtDGN3.Text), Convert.ToInt32(txtDGB3.Text), Convert.ToInt32(txtSoL3.Text));
                    new SanPhamBUS().Add(newData);
                    gridData3.DataSource = null;
                    gridData3.DataSource = new SanPhamBUS().LoadAccSP();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenSP3.Text = "";
            txtDGB3.Text = "";
            txtDGN3.Text = "";
            txtSoL3.Text = "";
        }

        //
        // Phương thức event khi nhấn Sửa ở tab sản phẩm
        //
        private void BtnEdit3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData3.Rows[gridData3.RowCount - 1].Cells[0].Value.ToString());
            new SanPhamBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenSP3.Text) && !string.IsNullOrWhiteSpace(txtDGN3.Text)
                    && !string.IsNullOrWhiteSpace(txtDGB3.Text) && !string.IsNullOrWhiteSpace(txtSoL3.Text))
                {
                    SanPham newData = new SanPham(0, txtTenSP3.Text, Convert.ToInt32(txtDGN3.Text),
                        Convert.ToInt32(txtDGB3.Text), Convert.ToInt32(txtSoL3.Text));
                    new SanPhamBUS().Update(newData);
                    gridData3.DataSource = null;
                    gridData3.DataSource = new SanPhamBUS().LoadAccSP();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenSP3.Text = "";
            txtDGN3.Text = "";
            txtDGB3.Text = "";
            txtSoL3.Text = "";
        }

        //
        // Phương thức event khi nhấn Xoá ở tab sản phẩm
        //
        private void BtnDel3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData3.Rows[gridData3.RowCount - 1].Cells[0].Value.ToString());
            new KhachBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenSP3.Text) && !string.IsNullOrWhiteSpace(txtDGN3.Text)
                    && !string.IsNullOrWhiteSpace(txtDGB3.Text) && !string.IsNullOrWhiteSpace(txtSoL3.Text))
                {
                    SanPham newData = new SanPham(0, txtTenSP3.Text, Convert.ToInt32(txtDGN3.Text),
                        Convert.ToInt32(txtDGB3.Text), Convert.ToInt32(txtSoL3.Text));
                    new SanPhamBUS().Delete(newData);
                    gridData3.DataSource = null;
                    gridData3.DataSource = new SanPhamBUS().LoadAccSP();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenSP3.Text = "";
            txtDGN3.Text = "";
            txtDGB3.Text = "";
            txtSoL3.Text = "";
        }
    }
}
