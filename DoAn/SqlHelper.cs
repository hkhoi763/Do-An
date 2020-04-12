 //
 // SqlHelper
 //	
 // Class kiểm tra kết nối
 // 
 // Tác giả: Nguyên Khôi
 // 
 //

using System.Data.SqlClient;

namespace DoAn
{
    public class SqlHelper
    {
        SqlConnection cn;

        public SqlHelper(string ConStr)
        {
            cn = new SqlConnection(ConStr);
        }

        //
        // Phương thức kiểm tra kết nối
        // Trả về True nếu thành công
        // 
        //
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
