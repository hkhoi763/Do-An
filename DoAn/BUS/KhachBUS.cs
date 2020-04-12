 //
 // KhachBUS
 //	
 // Class controller cho KhachDAO
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DAO;
using DoAn.DTO;
using System.Collections.Generic;

namespace DoAn.BUS
{
    public class KhachBUS
    {
        //
        // Phương thức truyền dẫn LoadAccKH
        //
        public List<Khach> LoadAccKH()
        {
            return new KhachDAO().LoadAccKH();
        }

        //
        // Phương thức truyền dẫn Update
        //
        public void Update(Khach kh)
        {
            new KhachDAO().Update(kh);
        }

        //
        // Phương thức truyền dẫn Add
        //
        public void Add(Khach kh)
        {
            new KhachDAO().Add(kh);
        }

        //
        // Phương thức truyền dẫn Reset
        //
        public void Reset(int i)
        {
            new KhachDAO().Reset(i);
        }

        //
        // Phương thức truyền dẫn Delete
        //
        public void Delete(Khach kh)
        {
            new KhachDAO().Delete(kh);
        }

        //
        // Phương thức truyền dẫn GetMaKH
        //
        public int GetMaKH(string tenKH)
        {
            return new KhachDAO().GetMaKH(tenKH);
        }
    }
}
