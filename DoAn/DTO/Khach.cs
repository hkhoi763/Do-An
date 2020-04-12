 //
 // Khach
 //	
 // Class định nghĩa đối tượng KHACH
 // 
 // Tác giả: Nguyên Khôi
 //
 //

namespace DoAn.DTO
{
    public class Khach
    {
        int _maKH;
        string _tenKH;
        string _diaChi;
        string _sDT;

        public int MaKh
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public string TenKh
        {
            get { return _tenKH; }
            set { _tenKH = value; }
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

        public Khach() { }

        public Khach(int maKH,string tenKH, string diaChi, string sDT)
        {
            _maKH = maKH;
            _tenKH = tenKH;
            _diaChi = diaChi;
            _sDT = sDT;
        }
    }
}
