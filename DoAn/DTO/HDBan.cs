 //
 // HDBan
 //	
 // Class định nghĩa đối tượng HDBAN
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using System;

namespace DoAn.DTO
{
    public class HDBan
    {
        int _maHDB;
        int _maKH;
        int _maNV;
        DateTime _ngayLap;
        int _thanhTien;

        public int MaHDB
        {
            get { return _maHDB; }
            set { _maHDB = value; }
        }

        public int MaKh
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public int MaNv
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }

        public int ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }

        public HDBan() { }

        public HDBan(int maHDB, int maKH, int maNV,DateTime ngayLap,int thanhTien)
        {
            _maHDB = maHDB;
            _maKH = maKH;
            _maNV = maNV;
            _ngayLap=ngayLap;
            _thanhTien = thanhTien;
        }
    }
}
