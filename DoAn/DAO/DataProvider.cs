 //
 // DataProvider
 //	
 // Class chứa chức năng liên quan thao tác với SQL
 // 
 // Tác giả: Nguyên Khôi
 //
 //

using System.Data.SqlClient;

namespace DoAn.DAO
{
    public class DataProvider
    {
        public static string _constr;
        SqlConnection cn;

        public DataProvider()
        {
            cn = new SqlConnection(_constr);
        }

        //
        // Phương thức mở kết nối 
        //
        public void Connect()
        {
            cn.Open();
        }

        //
        // Phương thức ngắt kết nối
        //
        public void Disconnect()
        {
            cn.Close();
        }

        //
        // Phương thức chạy đầu đọc reader
        //
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql,cn);
            return command.ExecuteReader();
        }

        //
        // Phương thức truy xuất thông tin dựa theo command được truyền vào
        //
        public void ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        } 
    }
}
