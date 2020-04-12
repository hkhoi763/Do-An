 //
 // KhachDAO
 //	
 // Class chứa chức năng liên quan KHACH
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class KhachDAO
    {
        DataProvider provider;

        public KhachDAO()
        {
            provider = new DataProvider();
        }

        //
        // Phương thức truy xuất thông tin khách hàng
        //
        public List<Khach> LoadAccKH()
        {
            string sql = "SELECT * FROM dbo.KHACH";
            return LoadData(sql);
        }

        //
        // Phương thức truy xuất thông tin khách hàng dựa theo command được truyền vào
        //
        public List<Khach> LoadData(string sql)
        {
            provider.Connect();
            SqlDataReader reader = provider.ExecuteReader(sql);

            List<Khach> list = new List<Khach>();
            while (reader.Read())
            {
                int maKH= reader.GetInt32(0);
                string tenKH=reader.GetString(1);
                string diaChi=reader.GetString(2);
                string sDT=reader.GetString(3);
                Khach s = new Khach(maKH, tenKH, diaChi, sDT);

                list.Add(s);
            }
            provider.Disconnect();
            return list;
        }

        //
        // Phương thức cập nhật thông tin khách hàng
        //
        public void Update(Khach kh)
        {
            provider.Connect();
            string sql = string.Format("UPDATE KHACH SET TENKH=N'{0}',DIACHI=N'{1}',SDT=N'{2}' WHERE TENKH=N'{0}'", kh.TenKh,kh.DiaChi,kh.SDT);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức thêm khách hàng
        //
        public void Add(Khach kh)
        {
            provider.Connect();
            string sql = string.Format("INSERT INTO KHACH(TENKH,DIACHI,SDT) VALUES " +
                "(N'{0}', N'{1}', N'{2}')", kh.TenKh, kh.DiaChi, kh.SDT);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức xoá khách hàng
        //
        public void Delete(Khach kh)
        {
            provider.Connect();
            string sql = string.Format("DELETE FROM KHACH WHERE TENKH=N'{0}'", kh.TenKh);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức reset lại số đếm tự động IDENTITY
        //
        public void Reset(int i)
        {
            provider.Connect();
            string sql = string.Format("DBCC CHECKIDENT ('dbo.KHACH', RESEED, {0})", i);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức lấy mã khách hàng dựa theo tên khách hàng
        //
        public int GetMaKH(string tenKH)
        {
            string sql = string.Format("SELECT * FROM KHACH WHERE TENKH=N'{0}'", tenKH);
            List<Khach> list = new KhachDAO().LoadData(sql);
            return list[0].MaKh;
        }
    }
}
