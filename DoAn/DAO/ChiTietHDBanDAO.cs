 //
 // ChiTietHDBanDAO
 //	
 // Class chứa chức năng liên quan CHITIETHDBAN
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class ChiTietHDBanDAO
    {
        DataProvider provider;

        public ChiTietHDBanDAO()
        {
            provider = new DataProvider();
        }

        //
        // Phương thức truy xuất thông tin chi tiết hoá đơn dựa theo command được truyền vào
        //
        public List<ChiTietHDBan> LoadData(string sql)
        {
            provider.Connect();
            SqlDataReader reader = provider.ExecuteReader(sql);

            List<ChiTietHDBan> list = new List<ChiTietHDBan>();
            while (reader.Read())
            {
                int maHDB = reader.GetInt32(0);
                int maSP = reader.GetInt32(1);
                int soLuong = reader.GetInt32(2);
                int tong = reader.GetInt32(3);
                ChiTietHDBan s = new ChiTietHDBan(maHDB, maSP, soLuong,tong);

                list.Add(s);
            }
            provider.Disconnect();
            return list;
        }

        //
        // Phương thức truy xuất thông tin hoá đơn
        //
        public List<ChiTietHDBan> LoadHD()
        {
            string sql = "SELECT * FROM dbo.CHITIETHDBAN";
            return LoadData(sql);
        }

        //
        // Phương thức thêm hoá đơn
        //
        public void Add(ChiTietHDBan cthdb)
        {
            provider.Connect();
            string sql = string.Format("INSERT INTO CHITIETHDBAN(MAHDB, MASP, SOLUONG, TONG) VALUES " +
                "({0},{1},{2},{3})", cthdb.MaHDB, cthdb.MaSp, cthdb.SoLuong, cthdb.Tong);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức lấy mã hoá đơn dựa theo mã khách hàng và mã nhân viên
        //
        public int GetMaHDB(int maKH, int maNV)
        {
            string sql = string.Format("SELECT * FROM HDBAN WHERE MAKH={0} AND MANV={1}", maKH, maNV);
            List<HDBan> list = new HDBanDAO().LoadData(sql);
            return list[0].MaHDB;
        }
    }
}
