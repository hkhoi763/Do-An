 //
 // SanPham
 //	
 // Class định nghĩa đối tượng SANPHAM
 // 
 // Tác giả: Nguyên Khôi
 // 
 //

namespace DoAn.DTO
{
    public class SanPham
    {
        int _maSP;
        string _tenSP;
        int _donGiaNhap;
        int _donGiaBan;
        int _soLuongTon;

        public int MaSp
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSp
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public int DonGiaNhap
        {
            get { return _donGiaNhap; }
            set { _donGiaNhap = value; }
        }

        public int DonGiaBan
        {
            get { return _donGiaBan; }
            set { _donGiaBan = value; }
        }

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        public SanPham() { }

        public SanPham(int maSP, string tenSP, int donGiaNhap, int donGiaBan, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _donGiaNhap = donGiaNhap;
            _donGiaBan = donGiaBan;
            _soLuongTon = soLuongTon;
        }
    }
}
