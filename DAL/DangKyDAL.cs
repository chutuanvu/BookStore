using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DangKyDAL
    {
        DatabaseHelper cSDL_DAL = new DatabaseHelper();

        public bool KiemTraTonTai(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Taikhoan = @TaiKhoan";
            cSDL_DAL.Ketnoi();
            cSDL_DAL.sqlCommand = new SqlCommand(query, cSDL_DAL.sqlConnection);
            cSDL_DAL.sqlCommand.Parameters.AddWithValue("@TaiKhoan", tenDangNhap);
            int result = (int)cSDL_DAL.sqlCommand.ExecuteScalar();
            cSDL_DAL.Ngatketnoi();
            return result > 0;
        }
        public DataTable getData()
        {
            string sql = "Select * from TaiKhoan";
            return cSDL_DAL.GetData(sql);
        }
        public bool Them(TaiKhoanDTO tk)
        {
            string query = string.Format("INSERT INTO TaiKhoan (Taikhoan, Matkhau, Email, SDT) VALUES ( '{0}','{1}',  '{2}', '{3}')", tk.Taikhoan, tk.Matkhau, tk.Email, tk.SDT);
            cSDL_DAL.Chaycodesql(query);
            return true;
        }
        public int Check(string ma)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Taikhoan = @TaiKhoan";
            cSDL_DAL.Ketnoi();
            using (SqlCommand command = new SqlCommand(sql, cSDL_DAL.sqlConnection))
            {
                command.Parameters.AddWithValue("@TaiKhoan", ma);
                int result = (int)command.ExecuteScalar();
                return result;
            }
        }


    }

}
