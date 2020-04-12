 //
 // ChiTietHDBanBUS
 //	
 // Class controller cho ChiTietHDBanDAO
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DAO;
using DoAn.DTO;
using System.Collections.Generic;

namespace DoAn.BUS
{
    public class ChiTietHDBanBUS
    {
        //
        // Phương thức truyền dẫn Add
        //
        public void Add(ChiTietHDBan cthdb)
        {
            new ChiTietHDBanDAO().Add(cthdb);
        }

        //
        // Phương thức truyền dẫn GetMaHDB
        //
        public int GetMaHDB(int maKH, int maNV)
        {
            return new ChiTietHDBanDAO().GetMaHDB(maKH,maNV);
        }

        //
        // Phương thức truyền dẫn LoadHD
        //
        public List<ChiTietHDBan> LoadHD()
        {
            return new ChiTietHDBanDAO().LoadHD();
        }
    }
}
