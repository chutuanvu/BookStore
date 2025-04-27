using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DangNhapDAL : DatabaseHelper
    {
        DatabaseHelper csdl = new DatabaseHelper();

        public bool KiemTraDangNhap(TaiKhoanDTO tk)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
            csdl.Ketnoi();
            csdl.sqlCommand = new SqlCommand(query, csdl.sqlConnection);
            csdl.sqlCommand.Parameters.AddWithValue("@TaiKhoan", tk.Taikhoan);
            csdl.sqlCommand.Parameters.AddWithValue("@MatKhau", tk.Matkhau);
            int kqtrave = (int)csdl.sqlCommand.ExecuteScalar();
            csdl.Ngatketnoi();
            return kqtrave > 0;
        }
    }
}

