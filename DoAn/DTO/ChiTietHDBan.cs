 //
 // ChiTietHDBan
 //	
 // Class định nghĩa đối tượng CHITIETHDBAN
 // 
 // Tác giả: Nguyên Khôi
 //
 //

namespace DoAn.DTO
{
    public class ChiTietHDBan
    {
        int _maHDB;
        int _maSP;
        int _soLuong;
        int _tong;

        public int MaHDB
        {
            get { return _maHDB; }
            set { _maHDB = value; }
        }

        public int MaSp
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public int Tong
        {
            get { return _tong; }
            set { _tong = value; }
        }

        public ChiTietHDBan() { }

        public ChiTietHDBan(int maHDB,int maSP, int soLuong, int tong)
        {
            _maHDB = maHDB;
            _maSP = maSP;
            _soLuong = soLuong;
            _tong = tong;
        }
    }
}
