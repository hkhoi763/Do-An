//
// frmManager
//	
// Form dành cho quản lý
// 
// Tác giả: Nguyên Khôi
//

using DoAn.BUS;
using DoAn.DTO;
using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmManager : Form
    {
        public string _tenDN;
        public string _pass;

        public frmManager()
        {
            InitializeComponent();
        }

        //
        // Phương thức event khi nhấn đăng xuất
        //
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // Phương thức event form load
        //
        private void FManager_Load(object sender, EventArgs e)
        {
            gridData0.DataSource = new TaiKhoanBUS().LoadAcc(_tenDN,_pass);
            txtID0.Text = gridData0.Rows[0].Cells[0].Value.ToString();
            gridData1.DataSource = new TaiKhoanBUS().LoadAccNV();
            gridData2.DataSource = new KhachBUS().LoadAccKH();
            gridData3.DataSource = new SanPhamBUS().LoadAccSP();
            gridData4.DataSource = new HDBanBUS().LoadHD();

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
                if (!string.IsNullOrWhiteSpace(txtID0.Text) && !string.IsNullOrWhiteSpace(txtHoTen0.Text) && !string.IsNullOrWhiteSpace(txtTenDN0.Text) && !string.IsNullOrWhiteSpace(txtNewPass0.Text)
                    && !string.IsNullOrWhiteSpace(txtChucVu0.Text) && !string.IsNullOrWhiteSpace(txtDC0.Text) && !string.IsNullOrWhiteSpace(txtSDT0.Text))
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
        // Phương thức event khi nhấn vào 1 dòng data grid view ở tab nhân viên
        //
        private void GridData1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;//lấy index của dòng đang chọn trên bảng
            txtHoTen1.Text = gridData1.Rows[numRow].Cells[1].Value.ToString();
            txtTenDN1.Text = gridData1.Rows[numRow].Cells[2].Value.ToString();
            txtPass1.Text = gridData1.Rows[numRow].Cells[3].Value.ToString();
            txtChucVu1.Text = gridData1.Rows[numRow].Cells[4].Value.ToString();
            txtDC1.Text = gridData1.Rows[numRow].Cells[5].Value.ToString();
            txtSDT1.Text = gridData1.Rows[numRow].Cells[6].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Thêm ở tab nhân viên
        //
        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData1.Rows[gridData1.RowCount - 1].Cells[0].Value.ToString());
            new TaiKhoanBUS().Reset(i);

            if(txtChucVu1.Text=="Quản lí")
            {
                MessageBox.Show("Chỉ nên có 1 quản lí");
            }    

            try
            {
                if (!string.IsNullOrWhiteSpace(txtHoTen1.Text) && !string.IsNullOrWhiteSpace(txtTenDN1.Text) && !string.IsNullOrWhiteSpace(txtPass1.Text)
                    && !string.IsNullOrWhiteSpace(txtChucVu1.Text) && !string.IsNullOrWhiteSpace(txtDC1.Text) && !string.IsNullOrWhiteSpace(txtSDT1.Text))
                {
                    TaiKhoan newData = new TaiKhoan(0, txtHoTen1.Text, txtTenDN1.Text, txtPass1.Text,
                txtChucVu1.Text, txtDC1.Text, txtSDT1.Text);
                    new TaiKhoanBUS().Add(newData);
                    gridData1.DataSource = null;
                    gridData1.DataSource = new TaiKhoanBUS().LoadAccNV();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtHoTen1.Text = "";
            txtTenDN1.Text = "";
            txtPass1.Text = "";
            txtChucVu1.Text = "";
            txtDC1.Text = "";
            txtSDT1.Text = "";
        }

        //
        // Phương thức event khi nhấn Sửa ở tab nhân viên
        //
        private void BtnEdit1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData1.Rows[gridData1.RowCount - 1].Cells[0].Value.ToString());
            new TaiKhoanBUS().Reset(i);

            if (txtChucVu1.Text == "Quản lí")
            {
                MessageBox.Show("Chỉ nên có 1 quản lý");
            }

            try
            {
                if (!string.IsNullOrWhiteSpace(txtHoTen1.Text) && !string.IsNullOrWhiteSpace(txtTenDN1.Text) && !string.IsNullOrWhiteSpace(txtPass1.Text)
                    && !string.IsNullOrWhiteSpace(txtChucVu1.Text) && !string.IsNullOrWhiteSpace(txtDC1.Text) && !string.IsNullOrWhiteSpace(txtSDT1.Text))
                {
                    TaiKhoan newData = new TaiKhoan(0, txtHoTen1.Text, txtTenDN1.Text, txtPass1.Text,
                txtChucVu1.Text, txtDC1.Text, txtSDT1.Text);
                    new TaiKhoanBUS().Update(newData);
                    gridData1.DataSource = null;
                    gridData1.DataSource = new TaiKhoanBUS().LoadAccNV();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtHoTen1.Text = "";
            txtTenDN1.Text = "";
            txtPass1.Text = "";
            txtChucVu1.Text = "";
            txtDC1.Text = "";
            txtSDT1.Text = "";
        }

        //
        // Phương thức event khi nhấn Xoá ở tab nhân viên
        //
        private void BtnDel1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData1.Rows[gridData1.RowCount - 1].Cells[0].Value.ToString());
            new TaiKhoanBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtHoTen1.Text) && !string.IsNullOrWhiteSpace(txtTenDN1.Text) && !string.IsNullOrWhiteSpace(txtPass1.Text)
                    && !string.IsNullOrWhiteSpace(txtChucVu1.Text) && !string.IsNullOrWhiteSpace(txtDC1.Text) && !string.IsNullOrWhiteSpace(txtSDT1.Text))
                {
                    TaiKhoan newData = new TaiKhoan(0, txtHoTen1.Text, txtTenDN1.Text, txtPass1.Text,
                txtChucVu1.Text, txtDC1.Text, txtSDT1.Text);
                    new TaiKhoanBUS().Delete(newData);
                    gridData1.DataSource = null;
                    gridData1.DataSource = new TaiKhoanBUS().LoadAccNV();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtHoTen1.Text = "";
            txtTenDN1.Text = "";
            txtPass1.Text = "";
            txtChucVu1.Text = "";
            txtDC1.Text = "";
            txtSDT1.Text = "";
        }

        //
        // Phương thức event khi nhấn vào 1 dòng data grid view ở tab khách hàng
        //
        private void GridData2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;//lấy index của dòng đang chọn trên bảng
            txtTenK2.Text = gridData2.Rows[numRow].Cells[1].Value.ToString();
            txtDC2.Text = gridData2.Rows[numRow].Cells[2].Value.ToString();
            txtSDT2.Text = gridData2.Rows[numRow].Cells[3].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Thêm ở tab khách hàng
        //
        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData2.Rows[gridData2.RowCount - 1].Cells[0].Value.ToString());
            new KhachBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenK2.Text) && !string.IsNullOrWhiteSpace(txtDC2.Text) && !string.IsNullOrWhiteSpace(txtSDT2.Text))
                {
                    Khach newData = new Khach(-1, txtTenK2.Text, txtDC2.Text, txtSDT2.Text);
                    new KhachBUS().Add(newData);
                    gridData2.DataSource = null;
                    gridData2.DataSource = new KhachBUS().LoadAccKH();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenK2.Text = "";
            txtDC2.Text = "";
            txtSDT2.Text = "";
        }

        //
        // Phương thức event khi nhấn Sửa ở tab khách hàng
        //
        private void BtnEdit2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData2.Rows[gridData2.RowCount - 1].Cells[0].Value.ToString());
            new KhachBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenK2.Text) && !string.IsNullOrWhiteSpace(txtDC2.Text) && !string.IsNullOrWhiteSpace(txtSDT2.Text))
                {
                    Khach newData = new Khach(0, txtTenK2.Text, txtDC2.Text, txtSDT2.Text);
                    new KhachBUS().Update(newData);
                    gridData2.DataSource = null;
                    gridData2.DataSource = new KhachBUS().LoadAccKH();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenK2.Text = "";
            txtDC2.Text = "";
            txtSDT2.Text = "";
        }

        //
        // Phương thức event khi nhấn Xoá ở tab khách hàng
        //
        private void BtnDel2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData2.Rows[gridData2.RowCount - 1].Cells[0].Value.ToString());
            new KhachBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtTenK2.Text) && !string.IsNullOrWhiteSpace(txtDC2.Text) && !string.IsNullOrWhiteSpace(txtSDT2.Text))
                {
                    Khach newData = new Khach(0, txtTenK2.Text, txtDC2.Text, txtSDT2.Text);
                    new KhachBUS().Delete(newData);
                    gridData2.DataSource = null;
                    gridData2.DataSource = new KhachBUS().LoadAccKH();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtTenK2.Text = "";
            txtDC2.Text = "";
            txtSDT2.Text = "";
        }

        //
        // Phương thức event khi nhấn vào 1 dòng data grid view ở tab sản phẩm
        //
        private void GridData3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;//lấy index của dòng đang chọn trên bảng
            txtTenSP3.Text = gridData3.Rows[numRow].Cells[1].Value.ToString();
            txtDGN3.Text= gridData3.Rows[numRow].Cells[2].Value.ToString();
            txtDGB3.Text= gridData3.Rows[numRow].Cells[3].Value.ToString();
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
            new KhachBUS().Reset(i);

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

        //
        // Phương thức event khi nhấn vào 1 dòng data grid view ở tab hoá đơn
        //
        private void GridData4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;//lấy index của dòng đang chọn trên bảng
            txtMaHD4.Text = gridData4.Rows[numRow].Cells[0].Value.ToString();
            txtMaKH4.Text = gridData4.Rows[numRow].Cells[1].Value.ToString();
            txtMaNV4.Text = gridData4.Rows[numRow].Cells[2].Value.ToString();
            dtmNgLap4.Text = gridData4.Rows[numRow].Cells[3].Value.ToString();
            txtTT4.Text = gridData4.Rows[numRow].Cells[4].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Xoá ở tab hoá đơn
        //
        private void BtnDel4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(gridData4.Rows[gridData4.RowCount - 1].Cells[0].Value.ToString());
            new HDBanBUS().Reset(i);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtMaHD4.Text) && !string.IsNullOrWhiteSpace(txtMaKH4.Text) && !string.IsNullOrWhiteSpace(txtMaNV4.Text)
                    && !string.IsNullOrWhiteSpace(dtmNgLap4.Text) && !string.IsNullOrWhiteSpace(txtTT4.Text))
                {
                    new HDBanBUS().Delete(txtMaHD4.Text);
                    gridData4.DataSource = null;
                    gridData4.DataSource = new HDBanBUS().LoadHD();
                }
                else
                    MessageBox.Show("Vui lòng nhập lại", "Message", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ", "Message", MessageBoxButtons.OK);
            }

            txtMaHD4.Text = "";
            txtMaKH4.Text = "";
            txtMaNV4.Text = "";
            dtmNgLap4.Value = DateTime.Now;
            txtTT4.Text = "";
        }

        //
        // Phương thức event khi nhấn Tìm kiếm ở tab hoá đơn
        //
        private void BtnSearch4_Click(object sender, EventArgs e)
        {
            gridData4.DataSource = new HDBanBUS().Search(txtMaHD4.Text);
            if (gridData4.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
