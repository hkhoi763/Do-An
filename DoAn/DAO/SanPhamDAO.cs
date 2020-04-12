 //
 // SanPhamDAO
 //	
 // Class chứa chức năng liên quan SANPHAM
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using DoAn.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class SanPhamDAO
    {
        DataProvider provider;

        public SanPhamDAO()
        {
            provider = new DataProvider();
        }

        //
        // Phương thức truy xuất thông tin sản phẩm
        //
        public List<SanPham> LoadAccSP()
        {
            string sql = "SELECT * FROM dbo.SANPHAM";
            return LoadData(sql);
        }

        //
        // Phương thức truy xuất thông tin sản phẩm dựa theo command được truyền vào
        //
        public List<SanPham> LoadData(string sql)
        {
            provider.Connect();
            SqlDataReader reader = provider.ExecuteReader(sql);

            List<SanPham> list = new List<SanPham>();
            while (reader.Read())
            {
                int maSP = reader.GetInt32(0);
                string tenSP = reader.GetString(1);
                int donGiaNhap = reader.GetInt32(2);
                int donGiaBan = reader.GetInt32(3);
                int soLuongTon = reader.GetInt32(4);
                SanPham s = new SanPham(maSP, tenSP,donGiaNhap,donGiaBan,soLuongTon);

                list.Add(s);
            }
            provider.Disconnect();
            return list;
        }

        //
        // Phương thức cập nhật thông tin sản phẩm
        //
        public void Update(SanPham sp)
        {
            provider.Connect();
            string sql = string.Format("UPDATE SANPHAM SET TENSP=N'{0}',DGNHAP={1}, DGBAN={2}, SOLUONGTON={3} WHERE TENSP=N'{0}'", sp.TenSp,sp.DonGiaNhap,sp.DonGiaBan,sp.SoLuongTon,sp.MaSp);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức thêm sản phẩm
        //
        public void Add(SanPham sp)
        {
            provider.Connect();
            string sql = string.Format("INSERT INTO SANPHAM(TENSP,DGNHAP,DGBAN,SOLUONGTON) VALUES " +
                "(N'{0}',{1},{2},{3})", sp.TenSp, sp.DonGiaNhap,sp.DonGiaBan,sp.SoLuongTon);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức xoá sản phẩm
        //
        public void Delete(SanPham sp)
        {
            provider.Connect();
            string sql = string.Format("DELETE FROM SANPHAM WHERE TENSP=N'{0}'", sp.TenSp);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức tìm kiếm thông tin sản phẩm
        //
        public List<SanPham> Search(string tenSP)
        {
            string sql = string.Format("SELECT * FROM dbo.SANPHAM WHERE TENSP=N'{0}'",tenSP);
            return LoadData(sql);
        }

        //
        // Phương thức reset lại số đếm tự động IDENTITY
        //
        public void Reset(int i)
        {
            provider.Connect();
            string sql = string.Format("DBCC CHECKIDENT ('dbo.SANPHAM', RESEED, {0})", i);
            provider.ExecuteQuery(sql);
            provider.Disconnect();
        }

        //
        // Phương thức lấy số lượng sản phẩm tồn kho dựa theo tên sản phẩm
        //
        public int GetSoL(string tenSP)
        {
            string sql = string.Format("SELECT * FROM SANPHAM WHERE TENSP=N'{0}'", tenSP);
            List<SanPham> list = new SanPhamDAO().LoadData(sql);
            return list[0].SoLuongTon;
        }

        //
        // Phương thức lấy đơn giá bán dựa theo tên sản phẩm
        //
        public int GetDGB(string tenSP)
        {
            string sql = string.Format("SELECT * FROM SANPHAM WHERE TENSP=N'{0}'", tenSP);
            List<SanPham> list = new SanPhamDAO().LoadData(sql);
            return list[0].DonGiaBan;
        }

        //
        // Phương thức lấy mã sản phẩm dựa theo tên sản phẩm
        //
        public int GetMaSP(string tenSP)
        {
            string sql = string.Format("SELECT * FROM SANPHAM WHERE TENSP=N'{0}'", tenSP);
            List<SanPham> list = new SanPhamDAO().LoadData(sql);
            return list[0].MaSp;
        }
    }
}
