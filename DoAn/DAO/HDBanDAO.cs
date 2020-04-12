 //
 // HDBanDAO
 //	
 // Class chứa chức năng liên quan HDBAN
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class HDBanDAO
    {
        DataProvider provider;

        public HDBanDAO()
        {
            provider = new DataProvider();
        }

        //
        // Phương thức truy xuất thông tin hoá đơn dựa theo command được truyền vào
        //
        public List<HDBan> LoadData(string sql)
        {
            provider.Connect();
            SqlDataReader reader = provider.ExecuteReader(sql);

            List<HDBan> list = new List<HDBan>();
            while (reader.Read())
            {
                int maHDB= reader.GetInt32(0);
                int maKH= reader.GetInt32(1);
                int maNV= reader.GetInt32(2);
                DateTime ngayLap= reader.GetDateTime(3);
                int thanhTien= reader.GetInt32(4);
                HDBan s = new HDBan(maHDB, maKH, maNV, ngayLap, thanhTien);

                list.Add(s);
            }
            provider.Disconnect();
            return list;
        }

        //
        // Phương thức truy xuất thông tin hoá đơn
        //
        public List<HDBan> LoadHD()
        {
            string sql = "SELECT * FROM dbo.HDBAN";
            return LoadData(sql);
        }

        //
        // Phương thức cập nhật thông tin hoá đơn
        //
        public void Update(HDBan hdb)
        {
            provider.Connect();
            string sql = string.Format("UPDATE HDBAN SET MAKH ={0}, MANV ={1}, NGLAP ={2}, THANHTIEN ={3} ", hdb.MaKh, hdb.MaNv, hdb.NgayLap, hdb.ThanhTien);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức thêm hoá đơn
        //
        public void Add(HDBan hdb)
        {
            provider.Connect();
            string sql = string.Format("INSERT INTO HDBAN (MAKH, MANV, NGLAP, THANHTIEN) VALUES " +
                "({0},{1},'{2}',{3})", hdb.MaKh, hdb.MaNv, hdb.NgayLap, hdb.ThanhTien);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức xoá hoá đơn
        //
        public void Delete(string maHDB)
        {
            provider.Connect();
            string sql1 = string.Format("DELETE FROM HDBAN WHERE MAHDB={0} ", maHDB);
            string sql2 = string.Format("DELETE FROM CHITIETHDBAN WHERE MAHDB={0} ", maHDB);
            provider.ExecuteQuery(sql2);
            provider.ExecuteQuery(sql1);
            provider.Disconnect();
        }

        //
        // Phương thức reset lại số đếm tự động IDENTITY
        //
        public void Reset(int i)
        {
            provider.Connect();
            string sql = string.Format("DBCC CHECKIDENT ('dbo.HDBAN', RESEED, {0})", i);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức tìm kiếm hoá đơn dựa theo mã hoá đơn
        //
        public List<HDBan> Search(string maHDB)
        {
            string sql = string.Format("SELECT * FROM dbo.SANPHAM WHERE MAHDB='{0}'", maHDB);
            return LoadData(sql);
        }
    }
}
