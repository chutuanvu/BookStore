using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QuenMatKhauDAL
    {
        private DatabaseHelper csdl = new DatabaseHelper();

        public bool KiemTraTonTai(string tenDangNhap, string email)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND Email = @Email ";

            csdl.Ketnoi();
            csdl.sqlCommand = new SqlCommand(query, csdl.sqlConnection);
            csdl.sqlCommand.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = tenDangNhap;
            csdl.sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;


            int result = (int)csdl.sqlCommand.ExecuteScalar();

            csdl.Ngatketnoi();

            return result > 0;
        }

        public DataTable getData()
        {
            string sql = "SELECT * FROM TaiKhoan";
            return csdl.GetData(sql);
        }

        public bool Sua(TaiKhoanDTO tk)
        {
            string query = string.Format("UPDATE TaiKhoan SET MatKhau = '{0}' WHERE TaiKhoan = '{1}'", tk.Matkhau, tk.Taikhoan);
            csdl.Chaycodesql(query);
            return true;
        }
    }
}