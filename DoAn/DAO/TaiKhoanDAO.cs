 //
 // TaiKhoanDAO
 //	
 // Class chứa chức năng liên quan TAIKHOAN
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class TaiKhoanDAO
    {
        readonly DataProvider provider;

        public TaiKhoanDAO()
        {
            provider = new DataProvider();
        }

        //
        // Phương thức kiểm tra đăng nhập
        //
        public string CheckLogin(string tenDN, string pass)
        {
            provider.Connect();
            string sql = string.Format("SELECT CHUCVU FROM TAIKHOAN WHERE TENDN=N'{0}' AND PASS=N'{1}'", tenDN, pass);
            SqlDataReader reader = provider.ExecuteReader(sql);
            reader.Read();
            string chucvu = reader.GetString(0);
            provider.Disconnect();

            return chucvu;
        }

        //
        // Phương thức truy xuất thông tin tài khoản
        //
        public List<TaiKhoan> LoadAcc(string tenDN, string pass)
        {
            string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENDN=N'{0}' AND PASS=N'{1}'", tenDN, pass);
            return LoadData(sql);
        }

        //
        // Phương thức truy xuất thông tin nhân viên
        //
        public List<TaiKhoan> LoadAccNV()
        {
            string sql = string.Format("SELECT * FROM TAIKHOAN WHERE CHUCVU!=N'Quản lí'");
            return LoadData(sql);
        }

         //
         // Phương thức truy xuất thông tin tài khoản dựa theo command được truyền vào
         //
        public List<TaiKhoan> LoadData(string sql)
        {
            provider.Connect();
            SqlDataReader reader = provider.ExecuteReader(sql);

            List<TaiKhoan> list = new List<TaiKhoan>();
            while (reader.Read())
            {
                int maNV = reader.GetInt32(0);
                string hoTen = reader.GetString(1);
                string tenDN = reader.GetString(2);
                string pass = reader.GetString(3);
                string chucVu = reader.GetString(4);
                string diaChi = reader.GetString(5);
                string sDT = reader.GetString(6);
                TaiKhoan s = new TaiKhoan(maNV, hoTen, tenDN, pass, chucVu, diaChi, sDT);

                list.Add(s);
            }
            provider.Disconnect();
            return list;
        }

        //
        // Phương thức cập nhật thông tin nhân viên
        //
        public void Update(TaiKhoan tk)
        { 
            provider.Connect();
            string sql= string.Format("UPDATE TAIKHOAN SET HOTEN=N'{0}',TENDN=N'{1}',PASS=N'{2}',CHUCVU=N'{3}'," +
                "DIACHI=N'{4}',SDT=N'{5}' WHERE MANV={6} OR HOTEN=N'{0}'", tk.HoTen,tk.TenDn,tk.Pass,tk.ChucVu,tk.DiaChi,tk.SDT,tk.MaNv);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức thêm nhân viên
        //
        public void Add(TaiKhoan tk)
        {
            provider.Connect();
            string sql = string.Format("INSERT INTO TAIKHOAN(HOTEN,TENDN,PASS,CHUCVU,DIACHI,SDT) VALUES " +
                "(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", tk.HoTen, tk.TenDn, tk.Pass, tk.ChucVu, tk.DiaChi, tk.SDT);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức xoá nhân viên
        //
        public void Delete(TaiKhoan tk)
        {
            provider.Connect();
            string sql = string.Format("DELETE FROM TAIKHOAN WHERE MANV={0} OR HOTEN=N'{1}'", tk.MaNv, tk.HoTen);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức reset lại số đếm tự động IDENTITY
        //
        public void Reset(int i)
        {
            provider.Connect();
            string sql = string.Format("DBCC CHECKIDENT ('dbo.TAIKHOAN', RESEED, {0})", i);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức lấy mã nhân viên dựa theo tên đăng nhập
        //
        public int GetMaNV(string tenDN)
        {
            string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENDN=N'{0}'", tenDN);
            List<TaiKhoan> list = new TaiKhoanDAO().LoadData(sql);
            return list[0].MaNv;
        }

        //
        // Phương thức lấy tên nhân viên dựa theo tên đăng nhập
        //
        public string GetTenNV(string tenDN)
        {
            string sql = string.Format("SELECT * FROM TAIKHOAN WHERE TENDN=N'{0}'", tenDN);
            List<TaiKhoan> list = new TaiKhoanDAO().LoadData(sql);
            return list[0].HoTen;
        }
    }
}
