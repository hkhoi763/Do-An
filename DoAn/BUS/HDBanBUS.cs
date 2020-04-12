 //
 // HDBanBUS
 //	
 // Class controller cho HDBanDAO
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DAO;
using DoAn.DTO;
using System.Collections.Generic;

namespace DoAn.BUS
{
    public class HDBanBUS
    {
        //
        // Phương thức truyền dẫn LoadHD
        //
        public List<HDBan> LoadHD()
        {
            return new HDBanDAO().LoadHD();
        }

        //
        // Phương thức truyền dẫn Add
        //
        public void Add(HDBan cthdb)
        {
            new HDBanDAO().Add(cthdb);
        }

        //
        // Phương thức truyền dẫn Delete
        //
        public void Delete(string maHDB)
        {
            new HDBanDAO().Delete(maHDB);
        }

        //
        // Phương thức truyền dẫn Reset
        //
        public void Reset(int i)
        {
            new HDBanDAO().Reset(i);
        }

        //
        // Phương thức truyền dẫn Search
        //
        public List<HDBan> Search(string maHDB)
        {
            return new HDBanDAO().Search(maHDB);
        }
    }
}
