 //
 // TaiKhoanBUS
 //	
 // Class controller cho TaiKhoanDAO
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DAO;
using DoAn.DTO;
using System.Collections.Generic;

namespace DoAn.BUS
{
    public class TaiKhoanBUS
    {
        //
        // Phương thức truyền dẫn CheckLogin
        //
        public string CheckLogin(string tenDN, string pass)
        {
            return new TaiKhoanDAO().CheckLogin(tenDN, pass);
        }

        //
        // Phương thức truyền dẫn LoadAcc
        //
        public List<TaiKhoan> LoadAcc(string tenDN, string pass)
        {
            return new TaiKhoanDAO().LoadAcc(tenDN, pass);
        }

        //
        // Phương thức truyền dẫn LoadAccNV
        //
        public List<TaiKhoan> LoadAccNV()
        {
            return new TaiKhoanDAO().LoadAccNV();
        }

        //
        // Phương thức truyền dẫn Update
        //
        public void Update(TaiKhoan tk)
        {
            new TaiKhoanDAO().Update(tk);
        }

        //
        // Phương thức truyền dẫn Add
        //
        public void Add(TaiKhoan tk)
        {
            new TaiKhoanDAO().Add(tk);
        }

        //
        // Phương thức truyền dẫn Reset
        //
        public void Reset(int i)
        {
            new TaiKhoanDAO().Reset(i);
        }

        //
        // Phương thức truyền dẫn Delete
        //
        public void Delete(TaiKhoan tk)
        {
            new TaiKhoanDAO().Delete(tk);
        }

        //
        // Phương thức truyền dẫn GetMaNV
        //
        public int GetMaNV(string tenDN)
        {
            return new TaiKhoanDAO().GetMaNV(tenDN);
        }

        //
        // Phương thức truyền dẫn GetTenNV
        //
        public string GetTenNV(string tenDN)
        {
            return new TaiKhoanDAO().GetTenNV(tenDN);
        }
    }
}
