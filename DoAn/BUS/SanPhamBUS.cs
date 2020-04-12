//
 // SanPhamBUS
 //	
 // Class controller cho SanPhamDAO
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DAO;
using DoAn.DTO;
using System.Collections.Generic;

namespace DoAn.BUS
{
    public class SanPhamBUS
    {
        //
        // Phương thức truyền dẫn LoadAccSP
        //
        public List<SanPham> LoadAccSP()
        {
            return new SanPhamDAO().LoadAccSP();
        }

        //
        // Phương thức truyền dẫn Update
        //
        public void Update(SanPham sp)
        {
            new SanPhamDAO().Update(sp);
        }

        //
        // Phương thức truyền dẫn Add
        //
        public void Add(SanPham sp)
        {
            new SanPhamDAO().Add(sp);
        }

        //
        // Phương thức truyền dẫn Delete
        //
        public void Delete(SanPham sp)
        {
            new SanPhamDAO().Delete(sp);
        }

        //
        // Phương thức truyền dẫn Search
        //
        public List<SanPham> Search(string tenSP)
        {
            return new SanPhamDAO().Search(tenSP);
        }

        //
        // Phương thức truyền dẫn Reset
        //
        public void Reset(int i)
        {
            new SanPhamDAO().Reset(i);
        }

        //
        // Phương thức truyền dẫn GetDGB
        //
        public int GetDGB(string tenSP)
        {
            return new SanPhamDAO().GetDGB(tenSP);
        }

        //
        // Phương thức truyền dẫn GetMaSp
        //
        public int GetMaSP(string tenSP)
        {
            return new SanPhamDAO().GetMaSP(tenSP);
        }

        //
        // Phương thức truyền dẫn GetSoL
        //
        public int GetSoL(string tenSP)
        {
            return new SanPhamDAO().GetSoL(tenSP);
        }
    }
}
