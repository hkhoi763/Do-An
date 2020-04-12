 //
 // TaiKhoan
 //	
 // Class định nghĩa đối tượng TAIKHOAN
 // 
 // Tác giả: Nguyên Khôi
 // 
 //

namespace DoAn.DTO
{
    public class TaiKhoan
    {
        int _maNV;
        string _hoTen;
        string _tenDN;
        string _pass;
        string _chucVu;
        string _diaChi;
        string _sDT;

        public int MaNv
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string TenDn
        {
            get { return _tenDN; }
            set { _tenDN = value; }
        }

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        public TaiKhoan() { }

        public TaiKhoan(int maNV,string hoTen, string tenDN, string pass, string chucVu, string diaChi, string sDT)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _tenDN = tenDN;
            _pass = pass;
            _chucVu = chucVu;
            _diaChi = diaChi;
            _sDT = sDT;
        }
    }
}
