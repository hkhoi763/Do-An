//
// frmEmployee
//	
// Form dành cho nhân viên
// 
// Tác giả: Nguyên Khôi
//

using DoAn.BUS;
using DoAn.DTO;
using System;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmEmployee : Form
    {
        public static string _tenDN;
        public static string _pass;

        public frmEmployee()
        {
            InitializeComponent();
        }

        //
        // Phương thức event form load
        //
        private void FMember_Load(object sender, EventArgs e)
        {
            gridData0.DataSource = new TaiKhoanBUS().LoadAcc(_tenDN, _pass);
            txtID0.Text = gridData0.Rows[0].Cells[0].Value.ToString();
            gridData2.DataSource = new KhachBUS().LoadAccKH();
            gridData3.DataSource = new SanPhamBUS().LoadAccSP();
            txtThanhTien4.Text = "0";

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
            txtID3.Text = gridData3.Rows[numRow].Cells[0].Value.ToString();
            txtTenSP3.Text = gridData3.Rows[numRow].Cells[1].Value.ToString();
            txtDGN3.Text= gridData3.Rows[numRow].Cells[2].Value.ToString();
            txtDGB3.Text= gridData3.Rows[numRow].Cells[3].Value.ToString();
            txtSoL3.Text = gridData3.Rows[numRow].Cells[4].Value.ToString();
        }

        //
        // Phương thức event khi nhấn Tìm kiếm ở tab sản phẩm
        //
        private void BtnSearch3_Click(object sender, EventArgs e)
        {
            gridData3.DataSource = new SanPhamBUS().Search(txtTenSP3.Text);
            if (gridData3.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Message", MessageBoxButtons.OK);
                gridData3.DataSource = new SanPhamBUS().LoadAccSP();
                gridData3.Refresh();
            }
        }

        //
        // Phương thức event khi nhấn Thêm ở tab hoá đơn
        // Mỗi lần nhấn thêm 1 sản phẩm vào data grid view
        //
        private void BtnAdd4_Click(object sender, EventArgs e)
        {
            try
            {
                int yeuCau = Convert.ToInt32(txtSoL4.Text);
                int thucTe = new SanPhamBUS().GetSoL(txtTenSP4.Text);
                int maSP = new SanPhamBUS().GetMaSP(txtTenSP4.Text);

                if (yeuCau > thucTe || yeuCau == 0)
                {
                    MessageBox.Show("Sản phẩm không đủ số lượng yêu cầu");
                }
                else
                {
                    int donGiaBan = new SanPhamBUS().GetDGB(txtTenSP4.Text);
                    int tong = donGiaBan * Convert.ToInt32(txtSoL4.Text);
                    int thanhTien = Convert.ToInt32(txtThanhTien4.Text);
                    gridData4.Rows.Add(txtTenSP4.Text, txtSoL4.Text, donGiaBan.ToString(), tong.ToString());

                    thanhTien += tong;
                    txtTenSP4.Text = "";
                    txtSoL4.Text = "";
                    txtThanhTien4.Text = thanhTien.ToString();
                }

                txtTenSP4.Text = "";
                txtSoL4.Text = "";
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin vừa nhập");
            }
        }

        //
        // Phương thức event khi nhấn In hoá đơn ở tab hoá đơn
        //
        private void BtnIn4_Click(object sender, EventArgs e)
        {
            int maNV = new TaiKhoanBUS().GetMaNV(_tenDN);
            Khach kh = new Khach(-1, txtK4.Text, txtDC4.Text, txtSDT4.Text);
            new KhachBUS().Add(kh);

            int maKH = new KhachBUS().GetMaKH(txtK4.Text);
            HDBan hdb = new HDBan(-1, maKH, maNV, dtNgTT4.Value, Convert.ToInt32(txtThanhTien4.Text));
            new HDBanBUS().Add(hdb);
            int maHDB = new ChiTietHDBanBUS().GetMaHDB(maKH, maNV);

            try
            { 
                for(int i=0;i<gridData4.Rows.Count-1;i++)
                {
                    int maSP = new SanPhamBUS().GetMaSP(gridData4.Rows[i].Cells[0].Value.ToString());
                    int soLuong = Convert.ToInt32(gridData4.Rows[i].Cells[1].Value.ToString());
                    int tong= Convert.ToInt32(gridData4.Rows[i].Cells[3].Value.ToString());
                    ChiTietHDBan cthdb = new ChiTietHDBan(maHDB, maSP, soLuong, tong);
                    new ChiTietHDBanBUS().Add(cthdb);
                }

                MessageBox.Show("Đã lưu hoá đơn vào ổ đĩa D");
                frmCryReport f = new frmCryReport
                {
                    _tenKH = txtK4.Text,
                    _maHDB = maHDB,
                    _tenNV = new TaiKhoanBUS().GetTenNV(_tenDN),
                    _ngLap = dtNgTT4.Value,
                    _tongTien = txtThanhTien4.Text
                };
                f.Show();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin");

                new HDBanBUS().Delete(maHDB.ToString());

                new KhachBUS().Delete(kh);
                int i = Convert.ToInt32(gridData2.Rows[gridData2.RowCount - 1].Cells[0].Value.ToString());
                new KhachBUS().Reset(i);

                gridData4.DataSource = new HDBanBUS().LoadHD();
                gridData4.Refresh();

                i = Convert.ToInt32(gridData3.Rows[gridData3.RowCount - 1].Cells[0].Value.ToString());

                new SanPhamBUS().Reset(i);
            }
        }
    }
}
